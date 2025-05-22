namespace ClinicRegistry
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageПациенты = new TabPage();
            tabPageДоктора = new TabPage();
            tabPageУслуги = new TabPage();
            tabPageПриёмы = new TabPage();
            tabPageМед = new TabPage();
            tabPageДиспансерноеНаблюдение = new TabPage();
            textSearch = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(386, 123);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 1;
            label1.Text = "Поликлиника";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageПациенты);
            tabControl1.Controls.Add(tabPageДоктора);
            tabControl1.Controls.Add(tabPageУслуги);
            tabControl1.Controls.Add(tabPageПриёмы);
            tabControl1.Controls.Add(tabPageМед);
            tabControl1.Controls.Add(tabPageДиспансерноеНаблюдение);
            tabControl1.Location = new Point(0, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1077, 35);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // tabPageПациенты
            // 
            tabPageПациенты.Location = new Point(4, 29);
            tabPageПациенты.Name = "tabPageПациенты";
            tabPageПациенты.Size = new Size(1069, 2);
            tabPageПациенты.TabIndex = 0;
            tabPageПациенты.Text = "Пациенты";
            tabPageПациенты.UseVisualStyleBackColor = true;
            // 
            // tabPageДоктора
            // 
            tabPageДоктора.Location = new Point(4, 29);
            tabPageДоктора.Name = "tabPageДоктора";
            tabPageДоктора.Size = new Size(1069, 2);
            tabPageДоктора.TabIndex = 1;
            tabPageДоктора.Text = "Доктора";
            tabPageДоктора.UseVisualStyleBackColor = true;
            // 
            // tabPageУслуги
            // 
            tabPageУслуги.Location = new Point(4, 29);
            tabPageУслуги.Name = "tabPageУслуги";
            tabPageУслуги.Size = new Size(1069, 2);
            tabPageУслуги.TabIndex = 2;
            tabPageУслуги.Text = "Услуги";
            tabPageУслуги.UseVisualStyleBackColor = true;
            // 
            // tabPageПриёмы
            // 
            tabPageПриёмы.Location = new Point(4, 29);
            tabPageПриёмы.Name = "tabPageПриёмы";
            tabPageПриёмы.Size = new Size(1069, 2);
            tabPageПриёмы.TabIndex = 3;
            tabPageПриёмы.Text = "Приёмы";
            tabPageПриёмы.UseVisualStyleBackColor = true;
            // 
            // tabPageМед
            // 
            tabPageМед.Location = new Point(4, 29);
            tabPageМед.Name = "tabPageМед";
            tabPageМед.Size = new Size(1069, 2);
            tabPageМед.TabIndex = 4;
            tabPageМед.Text = "Медицинские карты";
            tabPageМед.UseVisualStyleBackColor = true;
            // 
            // tabPageДиспансерноеНаблюдение
            // 
            tabPageДиспансерноеНаблюдение.Location = new Point(4, 29);
            tabPageДиспансерноеНаблюдение.Name = "tabPageДиспансерноеНаблюдение";
            tabPageДиспансерноеНаблюдение.Size = new Size(1069, 2);
            tabPageДиспансерноеНаблюдение.TabIndex = 5;
            tabPageДиспансерноеНаблюдение.Text = "Диспансерное наблюдение";
            tabPageДиспансерноеНаблюдение.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(12, 45);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Поиск...";
            textSearch.Size = new Size(300, 27);
            textSearch.TabIndex = 3;
            textSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(93, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(807, 400);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(336, 41);
            button1.Name = "button1";
            button1.Size = new Size(298, 36);
            button1.TabIndex = 5;
            button1.Text = "Детальная информация о пациентах";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(640, 41);
            button2.Name = "button2";
            button2.Size = new Size(260, 35);
            button2.TabIndex = 6;
            button2.Text = "Последние визиты пациентов";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 760);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textSearch);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Поликлиника";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageПациенты;
        private TabPage tabPageДоктора;
        private TabPage tabPageУслуги;
        private TabPage tabPageПриёмы;
        private TabPage tabPageМед;
        private TabPage tabPageДиспансерноеНаблюдение;
        private TextBox textSearch;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}
