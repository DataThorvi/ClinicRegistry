using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Xceed.Words.NET;


using DataTable = System.Data.DataTable;

namespace ClinicRegistry
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=localhost;Database=ClinicRegistryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private SqlConnection? connection;
        private SqlDataAdapter? adapter;
        private DataTable? currentTable;

        public Form1()
        {
            InitializeComponent();

            textSearch.TextChanged += TxtSearch_TextChanged;
            this.Load += Form1_Load;

            пациентыToolStripMenuItem.Click += пациентыToolStripMenuItem_Click;
            доктораToolStripMenuItem.Click += доктораToolStripMenuItem_Click;
            услугиToolStripMenuItem.Click += услугиToolStripMenuItem_Click;
            приёмыToolStripMenuItem.Click += приёмыToolStripMenuItem_Click;
            медToolStripMenuItem.Click += медToolStripMenuItem_Click;
            диспансерноеНаблюдениеToolStripMenuItem.Click += диспансерноеНаблюдениеToolStripMenuItem_Click;

            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            LoadPatients();
        }

        private void LoadPatients()
        {
            string query = "SELECT PatientID, LastName, FirstName, MiddleName, BirthDate FROM Patients";
            LoadData(query);
        }

        private void LoadDoctors()
        {
            string query = "SELECT DoctorID, LastName, FirstName, MiddleName, Specialization FROM Doctors";
            LoadData(query);
        }

        private void LoadServices()
        {
            string query = "SELECT ServiceID, ServiceName, Cost FROM Services";
            LoadData(query);
        }

        private void LoadAppointments()
        {
            string query = @"
                SELECT AppointmentID, PatientID, DoctorID, ServiceID, AppointmentDate, AppointmentTime, Diagnosis 
                FROM Appointments";
            LoadData(query);
        }

        private void LoadMedicalRecords()
        {
            string query = "SELECT RecordID, PatientID, DoctorID, Diagnosis, Treatment, RecordDate FROM MedicalRecords";
            LoadData(query);
        }

        private void LoadDispensaryObservations()
        {
            string query = "SELECT ObservationID, PatientID, DoctorID, StartDate, EndDate, Diagnosis FROM DispensaryObservations";
            LoadData(query);
        }

        private void LoadData(string query)
        {
            try
            {
                if (connection == null)
                    connection = new SqlConnection(connectionString);

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataTable table = new DataTable();
                adapter.Fill(table);

                currentTable = table;
                dataGridView1.DataSource = currentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (currentTable == null) return;

            string filterText = textSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filterText))
            {
                dataGridView1.DataSource = currentTable;
            }
            else
            {
                string filter = "";

                foreach (DataColumn col in currentTable.Columns)
                {
                    if (col.DataType == typeof(string))
                    {
                        if (filter.Length > 0) filter += " OR ";
                        filter += $"[{col.ColumnName}] LIKE '%{filterText}%'";
                    }
                }

                try
                {
                    DataView dv = currentTable.DefaultView;
                    dv.RowFilter = filter;
                    dataGridView1.DataSource = dv;
                }
                catch
                {
                   
                }
            }
        }

      
        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPatients();
            textSearch.Clear();
        }

        private void доктораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDoctors();
            textSearch.Clear();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadServices();
            textSearch.Clear();
        }

        private void приёмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAppointments();
            textSearch.Clear();
        }

        private void медToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMedicalRecords();
            textSearch.Clear();
        }

        private void диспансерноеНаблюдениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDispensaryObservations();
            textSearch.Clear();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            textSearch.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=ClinicRegistryDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = @"
               SELECT
        p.PatientID,
        p.LastName,
        p.FirstName,
        p.MiddleName,
        a.Diagnosis,
        a.AppointmentDate,
        d.LastName AS DoctorLastName,
        d.FirstName AS DoctorFirstName
    FROM Patients p
    OUTER APPLY (
        SELECT TOP 1 *
        FROM Appointments a
        WHERE a.PatientID = p.PatientID
        ORDER BY a.AppointmentDate DESC
    ) a
    LEFT JOIN Doctors d ON a.DoctorID = d.DoctorID;
        ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM vw_PatientsLastAppointment";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void GenerateWordReportFromTemplate(int patientId)
        {
            string templatePath = @"C:\Users\babes\Downloads\Template.docx";
            string outputPath = Path.Combine(Path.GetTempPath(), $"MedicalCard_{patientId}.docx");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

              
                string patientQuery = @"
            SELECT LastName, FirstName, MiddleName, BirthDate, Address, Phone, Gender, SNILS, OMS
            FROM Patients 
            WHERE PatientID = @PatientID";

                string lastName = "", firstName = "", middleName = "", birthDate = "", address = "", phone = "", gender = "", snils = "", oms = "";

                using (SqlCommand patientCmd = new SqlCommand(patientQuery, connection))
                {
                    patientCmd.Parameters.AddWithValue("@PatientID", patientId);
                    using (SqlDataReader reader = patientCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lastName = reader["LastName"].ToString();
                            firstName = reader["FirstName"].ToString();
                            middleName = reader["MiddleName"].ToString();
                            birthDate = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString();
                            address = reader["Address"].ToString();
                            phone = reader["Phone"].ToString();
                            gender = reader["Gender"].ToString();
                            snils = reader["SNILS"].ToString();
                            oms = reader["OMS"].ToString();
                        }
                    }
                }

               
                var doc = DocX.Load(templatePath);

               
                doc.ReplaceText("{{Фамилия}}", lastName);
                doc.ReplaceText("{{Имя}}", firstName);
                doc.ReplaceText("{{Отчество}}", middleName);
                doc.ReplaceText("{{ДатаРождения}}", birthDate);
                doc.ReplaceText("{{Адрес}}", address);
                doc.ReplaceText("{{Телефон}}", phone);
                doc.ReplaceText("{{Пол}}", gender);
                doc.ReplaceText("{{СНИЛС}}", snils);
                doc.ReplaceText("{{ОМС}}", oms);

              
                var table = doc.Tables[0];
                if (table.RowCount > 1)
                    table.RemoveRow(1); 

               
                string diagQuery = @"
    SELECT 
        StartDate, 
        EndDate, 
        Diagnosis, 
        ICDCode,
        (SELECT FirstName + ' ' + LastName FROM Doctors WHERE Doctors.DoctorID = DispensaryObservations.DoctorID) AS DoctorName
    FROM DispensaryObservations 
    WHERE PatientID = @PatientID";

                using (SqlCommand diagCmd = new SqlCommand(diagQuery, connection))
                {
                    diagCmd.Parameters.AddWithValue("@PatientID", patientId);
                    using (SqlDataReader diagReader = diagCmd.ExecuteReader())
                    {
                        while (diagReader.Read())
                        {
                            string startDate = diagReader["StartDate"] != DBNull.Value
                                ? Convert.ToDateTime(diagReader["StartDate"]).ToShortDateString()
                                : "";
                            string endDate = diagReader["EndDate"] != DBNull.Value
                                ? Convert.ToDateTime(diagReader["EndDate"]).ToShortDateString()
                                : "";
                            string diagnosis = diagReader["Diagnosis"].ToString();
                            string icd10 = diagReader["ICDCode"].ToString();
                            string doctor = diagReader["DoctorName"].ToString();

                            var row = table.InsertRow();
                            row.Cells[0].Paragraphs[0].Append(startDate);
                            row.Cells[1].Paragraphs[0].Append(endDate);
                            row.Cells[2].Paragraphs[0].Append(diagnosis);
                            row.Cells[3].Paragraphs[0].Append(icd10);
                            row.Cells[4].Paragraphs[0].Append(doctor);
                        }
                    }
                }

               
                doc.SaveAs(outputPath);

               
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = outputPath,
                    UseShellExecute = true
                });
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns.Contains("PatientID"))
            {
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value?.ToString(), out int patientId))
                {
                    GenerateWordReportFromTemplate(patientId);
                }
            }
        }
    }
}
