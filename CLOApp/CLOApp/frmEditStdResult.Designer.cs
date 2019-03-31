namespace CLOApp
{
    partial class frmEditStdResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditStdResult));
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDateEval = new System.Windows.Forms.DateTimePicker();
            this.lblEvalDate = new System.Windows.Forms.Label();
            this.cboAssessComp = new System.Windows.Forms.ComboBox();
            this.lblRubriclvl = new System.Windows.Forms.Label();
            this.lblAssessComp = new System.Windows.Forms.Label();
            this.cboStdId = new System.Windows.Forms.ComboBox();
            this.lblStdId = new System.Windows.Forms.Label();
            this.cboRubriclvl = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "EDIT STUDENT RESULT";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.1791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.8209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboAssessComp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAssessComp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboStdId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStdId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRubriclvl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboRubriclvl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEvalDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateEval, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 126);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // dtpDateEval
            // 
            this.dtpDateEval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateEval.Location = new System.Drawing.Point(341, 43);
            this.dtpDateEval.Name = "dtpDateEval";
            this.dtpDateEval.Size = new System.Drawing.Size(124, 20);
            this.dtpDateEval.TabIndex = 19;
            // 
            // lblEvalDate
            // 
            this.lblEvalDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEvalDate.AutoSize = true;
            this.lblEvalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvalDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEvalDate.Location = new System.Drawing.Point(253, 40);
            this.lblEvalDate.Name = "lblEvalDate";
            this.lblEvalDate.Size = new System.Drawing.Size(82, 32);
            this.lblEvalDate.TabIndex = 18;
            this.lblEvalDate.Text = "Evaluation \r\nDate";
            // 
            // cboAssessComp
            // 
            this.cboAssessComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAssessComp.FormattingEnabled = true;
            this.cboAssessComp.Location = new System.Drawing.Point(101, 43);
            this.cboAssessComp.Name = "cboAssessComp";
            this.cboAssessComp.Size = new System.Drawing.Size(146, 21);
            this.cboAssessComp.TabIndex = 17;
            // 
            // lblRubriclvl
            // 
            this.lblRubriclvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRubriclvl.AutoSize = true;
            this.lblRubriclvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubriclvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRubriclvl.Location = new System.Drawing.Point(253, 0);
            this.lblRubriclvl.Name = "lblRubriclvl";
            this.lblRubriclvl.Size = new System.Drawing.Size(82, 16);
            this.lblRubriclvl.TabIndex = 16;
            this.lblRubriclvl.Text = "RubricLevel";
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
            this.lblAssessComp.Size = new System.Drawing.Size(92, 32);
            this.lblAssessComp.TabIndex = 16;
            this.lblAssessComp.Text = "Assessment\r\nComponent";
            // 
            // cboStdId
            // 
            this.cboStdId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStdId.FormattingEnabled = true;
            this.cboStdId.Location = new System.Drawing.Point(101, 3);
            this.cboStdId.Name = "cboStdId";
            this.cboStdId.Size = new System.Drawing.Size(146, 21);
            this.cboStdId.TabIndex = 6;
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
            this.lblStdId.Size = new System.Drawing.Size(92, 16);
            this.lblStdId.TabIndex = 5;
            this.lblStdId.Text = "StudentID";
            // 
            // cboRubriclvl
            // 
            this.cboRubriclvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRubriclvl.FormattingEnabled = true;
            this.cboRubriclvl.Location = new System.Drawing.Point(341, 3);
            this.cboRubriclvl.Name = "cboRubriclvl";
            this.cboRubriclvl.Size = new System.Drawing.Size(124, 21);
            this.cboRubriclvl.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(390, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 73);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmEditStdResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(532, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEditStdResult";
            this.Text = "Editstdres";
            this.Load += new System.EventHandler(this.frmEditStdResult_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpDateEval;
        private System.Windows.Forms.Label lblEvalDate;
        private System.Windows.Forms.ComboBox cboAssessComp;
        private System.Windows.Forms.Label lblRubriclvl;
        private System.Windows.Forms.Label lblAssessComp;
        private System.Windows.Forms.ComboBox cboStdId;
        private System.Windows.Forms.Label lblStdId;
        private System.Windows.Forms.ComboBox cboRubriclvl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}