namespace CLOApp
{
    partial class frmEditAssess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAssess));
            this.lblEditAssessment = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.tblLyoutPanelAssess = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTotalWeightage = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.cboTotalWeightsge = new System.Windows.Forms.ComboBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tblLyoutPanelAssess.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditAssessment
            // 
            this.lblEditAssessment.AutoSize = true;
            this.lblEditAssessment.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAssessment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEditAssessment.Location = new System.Drawing.Point(12, 23);
            this.lblEditAssessment.Name = "lblEditAssessment";
            this.lblEditAssessment.Size = new System.Drawing.Size(243, 30);
            this.lblEditAssessment.TabIndex = 15;
            this.lblEditAssessment.Text = "EDIT ASSESSMENT";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(408, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 32);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblLyoutPanelAssess
            // 
            this.tblLyoutPanelAssess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLyoutPanelAssess.ColumnCount = 4;
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.38095F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.61905F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tblLyoutPanelAssess.Controls.Add(this.lblTitle, 0, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.lblDate, 0, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.lblTotalMarks, 2, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.lblTotalWeightage, 2, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.cboTitle, 1, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.cboTotalWeightsge, 3, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.txtTotalMarks, 3, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.dtpDate, 1, 1);
            this.tblLyoutPanelAssess.Location = new System.Drawing.Point(10, 114);
            this.tblLyoutPanelAssess.Name = "tblLyoutPanelAssess";
            this.tblLyoutPanelAssess.RowCount = 2;
            this.tblLyoutPanelAssess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyoutPanelAssess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyoutPanelAssess.Size = new System.Drawing.Size(487, 85);
            this.tblLyoutPanelAssess.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(5, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMarks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalMarks.Location = new System.Drawing.Point(218, 11);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(87, 20);
            this.lblTotalMarks.TabIndex = 3;
            this.lblTotalMarks.Text = "TotalMarks";
            // 
            // lblTotalWeightage
            // 
            this.lblTotalWeightage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalWeightage.AutoSize = true;
            this.lblTotalWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeightage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalWeightage.Location = new System.Drawing.Point(218, 43);
            this.lblTotalWeightage.Name = "lblTotalWeightage";
            this.lblTotalWeightage.Size = new System.Drawing.Size(86, 40);
            this.lblTotalWeightage.TabIndex = 2;
            this.lblTotalWeightage.Text = "Total\r\nWeightage";
            // 
            // cboTitle
            // 
            this.cboTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Quiz",
            "Mids",
            "Final",
            "Lab1",
            "Lab2",
            "Lab3",
            "Lab4",
            "Lab5",
            "Lab6",
            "Lab7",
            "Lab8",
            "Lab9",
            "Lab10"});
            this.cboTitle.Location = new System.Drawing.Point(61, 10);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(148, 21);
            this.cboTitle.TabIndex = 5;
            // 
            // cboTotalWeightsge
            // 
            this.cboTotalWeightsge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTotalWeightsge.FormattingEnabled = true;
            this.cboTotalWeightsge.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75%",
            "80%",
            "85%",
            "90%",
            "95%",
            "100%"});
            this.cboTotalWeightsge.Location = new System.Drawing.Point(314, 53);
            this.cboTotalWeightsge.Name = "cboTotalWeightsge";
            this.cboTotalWeightsge.Size = new System.Drawing.Size(170, 21);
            this.cboTotalWeightsge.TabIndex = 7;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalMarks.Location = new System.Drawing.Point(314, 11);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(170, 20);
            this.txtTotalMarks.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDate.Location = new System.Drawing.Point(61, 53);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(148, 20);
            this.dtpDate.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblEditAssessment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 74);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmEditAssess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(513, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tblLyoutPanelAssess);
            this.Name = "frmEditAssess";
            this.Text = "Editassess";
            this.Load += new System.EventHandler(this.Editassess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tblLyoutPanelAssess.ResumeLayout(false);
            this.tblLyoutPanelAssess.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEditAssessment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tblLyoutPanelAssess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblTotalWeightage;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.ComboBox cboTotalWeightsge;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}