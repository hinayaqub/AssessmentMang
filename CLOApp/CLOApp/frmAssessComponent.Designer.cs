namespace CLOApp
{
    partial class frmAssessComponent
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblAssessmentComponent = new System.Windows.Forms.Label();
            this.dgvAssessmentComponent = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblLyoutPanelAssess = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRubricId = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboRubricId = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessmentComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tblLyoutPanelAssess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAssessmentComponent
            // 
            this.lblAssessmentComponent.AutoSize = true;
            this.lblAssessmentComponent.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessmentComponent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssessmentComponent.Location = new System.Drawing.Point(23, 26);
            this.lblAssessmentComponent.Name = "lblAssessmentComponent";
            this.lblAssessmentComponent.Size = new System.Drawing.Size(337, 30);
            this.lblAssessmentComponent.TabIndex = 5;
            this.lblAssessmentComponent.Text = "ASSESSMENT COMPONENT";
            // 
            // dgvAssessmentComponent
            // 
            this.dgvAssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssessmentComponent.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvAssessmentComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssessmentComponent.GridColor = System.Drawing.Color.Teal;
            this.dgvAssessmentComponent.Location = new System.Drawing.Point(4, 280);
            this.dgvAssessmentComponent.Name = "dgvAssessmentComponent";
            this.dgvAssessmentComponent.Size = new System.Drawing.Size(521, 172);
            this.dgvAssessmentComponent.TabIndex = 10;
            this.dgvAssessmentComponent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(443, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(443, 458);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblAssessmentComponent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 77);
            this.panel1.TabIndex = 16;
            // 
            // tblLyoutPanelAssess
            // 
            this.tblLyoutPanelAssess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLyoutPanelAssess.ColumnCount = 4;
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.38095F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.61905F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tblLyoutPanelAssess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tblLyoutPanelAssess.Controls.Add(this.lblTotalMarks, 2, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.lblName, 0, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.lblRubricId, 0, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.cboName, 1, 0);
            this.tblLyoutPanelAssess.Controls.Add(this.cboRubricId, 1, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.lblDate, 2, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.dtpDate, 3, 1);
            this.tblLyoutPanelAssess.Controls.Add(this.txtTotalMarks, 3, 0);
            this.tblLyoutPanelAssess.Location = new System.Drawing.Point(0, 95);
            this.tblLyoutPanelAssess.Name = "tblLyoutPanelAssess";
            this.tblLyoutPanelAssess.RowCount = 2;
            this.tblLyoutPanelAssess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyoutPanelAssess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyoutPanelAssess.Size = new System.Drawing.Size(525, 85);
            this.tblLyoutPanelAssess.TabIndex = 17;
            this.tblLyoutPanelAssess.Paint += new System.Windows.Forms.PaintEventHandler(this.tblLyoutPanelAssess_Paint);
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMarks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalMarks.Location = new System.Drawing.Point(237, 11);
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
            this.lblName.Location = new System.Drawing.Point(7, 12);
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
            "Lab1",
            "Lab2",
            "Lab3",
            "Lab4",
            "Lab5",
            "Lab6",
            "Lab7",
            "Lab8",
            "Lab9"});
            this.cboName.Location = new System.Drawing.Point(66, 10);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(163, 21);
            this.cboName.TabIndex = 6;
            // 
            // cboRubricId
            // 
            this.cboRubricId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRubricId.FormattingEnabled = true;
            this.cboRubricId.Location = new System.Drawing.Point(66, 53);
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
            this.lblDate.Location = new System.Drawing.Point(261, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpDate.Location = new System.Drawing.Point(340, 53);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(182, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalMarks.Location = new System.Drawing.Point(338, 11);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(179, 20);
            this.txtTotalMarks.TabIndex = 9;
            this.txtTotalMarks.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotalMarks_Validating);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(12, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAssessComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(570, 505);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tblLyoutPanelAssess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAssessmentComponent);
            this.Name = "frmAssessComponent";
            this.Text = "AssessCompo";
            this.Load += new System.EventHandler(this.AssessCompo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessmentComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblLyoutPanelAssess.ResumeLayout(false);
            this.tblLyoutPanelAssess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblAssessmentComponent;
        private System.Windows.Forms.DataGridView dgvAssessmentComponent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tblLyoutPanelAssess;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRubricId;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ComboBox cboRubricId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
    }
}