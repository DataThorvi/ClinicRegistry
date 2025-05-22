namespace ClinicRegistry
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            пациентыToolStripMenuItem = new ToolStripMenuItem();
            доктораToolStripMenuItem = new ToolStripMenuItem();
            услугиToolStripMenuItem = new ToolStripMenuItem();
            приёмыToolStripMenuItem = new ToolStripMenuItem();
            медToolStripMenuItem = new ToolStripMenuItem();
            диспансерноеНаблюдениеToolStripMenuItem = new ToolStripMenuItem();
            textSearch = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 320);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(450, 363);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 1;
            label1.Text = "Поликлиника";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { пациентыToolStripMenuItem, доктораToolStripMenuItem, услугиToolStripMenuItem, приёмыToolStripMenuItem, медToolStripMenuItem, диспансерноеНаблюдениеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1077, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // пациентыToolStripMenuItem
            // 
            пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            пациентыToolStripMenuItem.Size = new Size(94, 24);
            пациентыToolStripMenuItem.Text = "Пациенты";
            пациентыToolStripMenuItem.Click += пациентыToolStripMenuItem_Click;
            // 
            // доктораToolStripMenuItem
            // 
            доктораToolStripMenuItem.Name = "доктораToolStripMenuItem";
            доктораToolStripMenuItem.Size = new Size(81, 24);
            доктораToolStripMenuItem.Text = "Доктора";
            доктораToolStripMenuItem.Click += доктораToolStripMenuItem_Click;
            // 
            // услугиToolStripMenuItem
            // 
            услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            услугиToolStripMenuItem.Size = new Size(69, 24);
            услугиToolStripMenuItem.Text = "Услуги";
            услугиToolStripMenuItem.Click += услугиToolStripMenuItem_Click;
            // 
            // приёмыToolStripMenuItem
            // 
            приёмыToolStripMenuItem.Name = "приёмыToolStripMenuItem";
            приёмыToolStripMenuItem.Size = new Size(82, 24);
            приёмыToolStripMenuItem.Text = "Приёмы";
            приёмыToolStripMenuItem.Click += приёмыToolStripMenuItem_Click;
            // 
            // медToolStripMenuItem
            // 
            медToolStripMenuItem.Name = "медToolStripMenuItem";
            медToolStripMenuItem.Size = new Size(164, 24);
            медToolStripMenuItem.Text = "Медицинские карты";
            медToolStripMenuItem.Click += медToolStripMenuItem_Click;
            // 
            // диспансерноеНаблюдениеToolStripMenuItem
            // 
            диспансерноеНаблюдениеToolStripMenuItem.Name = "диспансерноеНаблюдениеToolStripMenuItem";
            диспансерноеНаблюдениеToolStripMenuItem.Size = new Size(217, 24);
            диспансерноеНаблюдениеToolStripMenuItem.Text = "Диспансерное наблюдение";
            диспансерноеНаблюдениеToolStripMenuItem.Click += диспансерноеНаблюдениеToolStripMenuItem_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(12, 40);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Поиск...";
            textSearch.Size = new Size(300, 27);
            textSearch.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(12, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 650);
            dataGridView1.TabIndex = 4;
         
            // 
            // button1
            // 
            button1.Location = new Point(327, 35);
            button1.Name = "button1";
            button1.Size = new Size(298, 36);
            button1.TabIndex = 5;
            button1.Text = "детальная информация о пациентах";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(640, 35);
            button2.Name = "button2";
            button2.Size = new Size(260, 35);
            button2.TabIndex = 6;
            button2.Text = " Последение визиты пациентов";
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
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Поликлиника";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem пациентыToolStripMenuItem;
        private ToolStripMenuItem доктораToolStripMenuItem;
        private ToolStripMenuItem услугиToolStripMenuItem;
        private ToolStripMenuItem приёмыToolStripMenuItem;
        private ToolStripMenuItem медToolStripMenuItem;
        private ToolStripMenuItem диспансерноеНаблюдениеToolStripMenuItem;
        private TextBox textSearch;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}
