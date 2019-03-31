namespace CLOApp
{
    partial class frmEditAssComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAssComp));
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblLyoutPanelAssess = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRubricId = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboRubricId = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tblLyoutPanelAssess.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "EDIT ASSESSMENT COMPONENT";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblLyoutPanelAssess
            // 
            this.tblLyoutPanelAssess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLyoutPanelAssess.ColumnCount = 4;
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.38095F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.61905F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tblLyoutPanelAssess.Controls.Add(this.lblTotalMarks, 2, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.lblName, 0, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.lblRubricId, 0, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.cboName, 1, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.cboRubricId, 1, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.lblDate, 2, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.dtpDate, 3, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.txtTotalMarks, 3, 0);
            this.tblLyoutPanelAssess.Location = new System.Drawing.Point(17, 111);
            this.tblLyoutPanelAssess.Name = "tblLyoutPanelAssess";
            this.tblLyoutPanelAssess.RowCount = 2;
            this.tblLyoutPanelAssess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyoutPanelAssess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyoutPanelAssess.Size = new System.Drawing.Size(525, 85);
            this.tblLyoutPanelAssess.TabIndex = 24;
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMarks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalMarks.Location = new System.Drawing.Point(238, 11);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(87, 20);
            this.lblTotalMarks.TabIndex = 3;
            this.lblTotalMarks.Text = "TotalMarks";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(8, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblRubricId
            // 
            this.lblRubricId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRubricId.AutoSize = true;
            this.lblRubricId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubricId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRubricId.Location = new System.Drawing.Point(4, 45);
            this.lblRubricId.Name = "lblRubricId";
            this.lblRubricId.Size = new System.Drawing.Size(55, 36);
            this.lblRubricId.TabIndex = 3;
            this.lblRubricId.Text = "Rubric Id";
            // 
            // cboName
            // 
            this.cboName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "Question 1",
            "Question 2",
            "Question 3",
            "Question 4",
            "Question 5",
            "Question 6",
            "Question 7",
            "Question 8",
            "Question 9",
            "Question 10",
            "Question 11",
            "Question 12",
            "Question 13",
            "Question 14",
            "Question 15",
            "Question 16",
            "Question 17",
            "Question 18",
            "Question 19",
            "Question 20",
            "Question 21",
            "Question 22",
            "",
            "Question 2"});
            this.cboName.Location = new System.Drawing.Point(67, 10);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(163, 21);
            this.cboName.TabIndex = 6;
            // 
            // cboRubricId
            // 
            this.cboRubricId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRubricId.FormattingEnabled = true;
            this.cboRubricId.Location = new System.Drawing.Point(67, 53);
            this.cboRubricId.Name = "cboRubricId";
            this.cboRubricId.Size = new System.Drawing.Size(163, 21);
            this.cboRubricId.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(262, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Location = new System.Drawing.Point(334, 53);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(188, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalMarks.Location = new System.Drawing.Point(338, 11);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(179, 20);
            this.txtTotalMarks.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(474, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 32);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 83);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmEditAssComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(603, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblLyoutPanelAssess);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditAssComp";
            this.Text = "Editasscomp";
            this.Load += new System.EventHandler(this.Editasscomp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tblLyoutPanelAssess.ResumeLayout(false);
            this.tblLyoutPanelAssess.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tblLyoutPanelAssess;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRubricId;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ComboBox cboRubricId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Button btnSave;
    }
}