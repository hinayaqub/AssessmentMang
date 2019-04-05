namespace CLOApp
{
    partial class frmStudentResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentResult));
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStdres = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlStudentResult = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDateEval = new System.Windows.Forms.DateTimePicker();
            this.lblEvalDate = new System.Windows.Forms.Label();
            this.cboAssessComp = new System.Windows.Forms.ComboBox();
            this.lblRubriclvl = new System.Windows.Forms.Label();
            this.cboAssessment = new System.Windows.Forms.ComboBox();
            this.lblAssessComp = new System.Windows.Forms.Label();
            this.cboStdId = new System.Windows.Forms.ComboBox();
            this.lblAssess = new System.Windows.Forms.Label();
            this.lblStdId = new System.Windows.Forms.Label();
            this.cboRubriclvl = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlStudentResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "STUDENT RESULT";
            // 
            // dgvStdres
            // 
            this.dgvStdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStdres.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvStdres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStdres.GridColor = System.Drawing.Color.Teal;
            this.dgvStdres.Location = new System.Drawing.Point(41, 314);
            this.dgvStdres.Name = "dgvStdres";
            this.dgvStdres.Size = new System.Drawing.Size(525, 188);
            this.dgvStdres.TabIndex = 10;
            this.dgvStdres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Snow;
            this.btnUpdate.Location = new System.Drawing.Point(485, 506);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlStudentResult
            // 
            this.pnlStudentResult.BackColor = System.Drawing.Color.Teal;
            this.pnlStudentResult.Controls.Add(this.pictureBox1);
            this.pnlStudentResult.Controls.Add(this.label5);
            this.pnlStudentResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentResult.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentResult.Name = "pnlStudentResult";
            this.pnlStudentResult.Size = new System.Drawing.Size(591, 70);
            this.pnlStudentResult.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.1791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.8209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Controls.Add(this.dtpDateEval, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEvalDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboAssessComp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRubriclvl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboAssessment, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAssessComp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboStdId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAssess, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStdId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboRubriclvl, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 126);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dtpDateEval
            // 
            this.dtpDateEval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateEval.Location = new System.Drawing.Point(100, 83);
            this.dtpDateEval.Name = "dtpDateEval";
            this.dtpDateEval.Size = new System.Drawing.Size(146, 20);
            this.dtpDateEval.TabIndex = 19;
            // 
            // lblEvalDate
            // 
            this.lblEvalDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEvalDate.AutoSize = true;
            this.lblEvalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvalDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEvalDate.Location = new System.Drawing.Point(3, 80);
            this.lblEvalDate.Name = "lblEvalDate";
            this.lblEvalDate.Size = new System.Drawing.Size(91, 32);
            this.lblEvalDate.TabIndex = 18;
            this.lblEvalDate.Text = "Evaluation \r\nDate";
            // 
            // cboAssessComp
            // 
            this.cboAssessComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAssessComp.FormattingEnabled = true;
            this.cboAssessComp.Location = new System.Drawing.Point(100, 43);
            this.cboAssessComp.Name = "cboAssessComp";
            this.cboAssessComp.Size = new System.Drawing.Size(146, 21);
            this.cboAssessComp.TabIndex = 17;
            this.cboAssessComp.SelectedIndexChanged += new System.EventHandler(this.cboAssessComp_SelectedIndexChanged);
            this.cboAssessComp.Click += new System.EventHandler(this.cboAssessComp_Click);
            this.cboAssessComp.Validating += new System.ComponentModel.CancelEventHandler(this.cboAssessComp_Validating);
            // 
            // lblRubriclvl
            // 
            this.lblRubriclvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRubriclvl.AutoSize = true;
            this.lblRubriclvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubriclvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRubriclvl.Location = new System.Drawing.Point(252, 40);
            this.lblRubriclvl.Name = "lblRubriclvl";
            this.lblRubriclvl.Size = new System.Drawing.Size(82, 16);
            this.lblRubriclvl.TabIndex = 16;
            this.lblRubriclvl.Text = "RubricLevel";
            // 
            // cboAssessment
            // 
            this.cboAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAssessment.FormattingEnabled = true;
            this.cboAssessment.Location = new System.Drawing.Point(340, 3);
            this.cboAssessment.Name = "cboAssessment";
            this.cboAssessment.Size = new System.Drawing.Size(125, 21);
            this.cboAssessment.TabIndex = 17;
            this.cboAssessment.Validating += new System.ComponentModel.CancelEventHandler(this.cboAssessment_Validating);
            // 
            // lblAssessComp
            // 
            this.lblAssessComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssessComp.AutoSize = true;
            this.lblAssessComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssessComp.Location = new System.Drawing.Point(3, 40);
            this.lblAssessComp.Name = "lblAssessComp";
            this.lblAssessComp.Size = new System.Drawing.Size(91, 32);
            this.lblAssessComp.TabIndex = 16;
            this.lblAssessComp.Text = "Assessment\r\nComponent";
            // 
            // cboStdId
            // 
            this.cboStdId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStdId.FormattingEnabled = true;
            this.cboStdId.Location = new System.Drawing.Point(100, 3);
            this.cboStdId.Name = "cboStdId";
            this.cboStdId.Size = new System.Drawing.Size(146, 21);
            this.cboStdId.TabIndex = 6;
            this.cboStdId.Validating += new System.ComponentModel.CancelEventHandler(this.cboStdId_Validating);
            // 
            // lblAssess
            // 
            this.lblAssess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssess.AutoSize = true;
            this.lblAssess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssess.Location = new System.Drawing.Point(252, 0);
            this.lblAssess.Name = "lblAssess";
            this.lblAssess.Size = new System.Drawing.Size(82, 16);
            this.lblAssess.TabIndex = 16;
            this.lblAssess.Text = "Assessment";
            // 
            // lblStdId
            // 
            this.lblStdId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStdId.AutoSize = true;
            this.lblStdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStdId.Location = new System.Drawing.Point(3, 0);
            this.lblStdId.Name = "lblStdId";
            this.lblStdId.Size = new System.Drawing.Size(91, 16);
            this.lblStdId.TabIndex = 5;
            this.lblStdId.Text = "StudentID";
            // 
            // cboRubriclvl
            // 
            this.cboRubriclvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRubriclvl.FormattingEnabled = true;
            this.cboRubriclvl.Location = new System.Drawing.Point(340, 43);
            this.cboRubriclvl.Name = "cboRubriclvl";
            this.cboRubriclvl.Size = new System.Drawing.Size(125, 21);
            this.cboRubriclvl.TabIndex = 17;
            this.cboRubriclvl.Validating += new System.ComponentModel.CancelEventHandler(this.cboAssessComp_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(454, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(40, 270);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(138, 29);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "Information:";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Teal;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.Snow;
            this.Backbtn.Location = new System.Drawing.Point(32, 524);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 33);
            this.Backbtn.TabIndex = 17;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // frmStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(591, 588);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlStudentResult);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvStdres);
            this.Controls.Add(this.btnSave);
            this.Name = "frmStudentResult";
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.re);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlStudentResult.ResumeLayout(false);
            this.pnlStudentResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvStdres;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlStudentResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpDateEval;
        private System.Windows.Forms.Label lblEvalDate;
        private System.Windows.Forms.ComboBox cboRubriclvl;
        private System.Windows.Forms.ComboBox cboAssessComp;
        private System.Windows.Forms.Label lblRubriclvl;
        private System.Windows.Forms.ComboBox cboAssessment;
        private System.Windows.Forms.Label lblAssessComp;
        private System.Windows.Forms.ComboBox cboStdId;
        private System.Windows.Forms.Label lblAssess;
        private System.Windows.Forms.Label lblStdId;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Backbtn;
    }
}