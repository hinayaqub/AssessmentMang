namespace CLOApp
{
    partial class frmAttendenceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendenceDetail));
            this.lblClassAttendence = new System.Windows.Forms.Label();
            this.dgvClassAttendence = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelClassAttendence = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picClassAttendence = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassAttendence)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelClassAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClassAttendence)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassAttendence
            // 
            this.lblClassAttendence.AutoSize = true;
            this.lblClassAttendence.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassAttendence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassAttendence.Location = new System.Drawing.Point(22, 27);
            this.lblClassAttendence.Name = "lblClassAttendence";
            this.lblClassAttendence.Size = new System.Drawing.Size(268, 30);
            this.lblClassAttendence.TabIndex = 0;
            this.lblClassAttendence.Text = "Class Attendence";
            this.lblClassAttendence.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvClassAttendence
            // 
            this.dgvClassAttendence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClassAttendence.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvClassAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassAttendence.Location = new System.Drawing.Point(12, 253);
            this.dgvClassAttendence.Name = "dgvClassAttendence";
            this.dgvClassAttendence.Size = new System.Drawing.Size(518, 203);
            this.dgvClassAttendence.TabIndex = 1;
            this.dgvClassAttendence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassAttendence_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(460, 462);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.picClassAttendence);
            this.panel1.Controls.Add(this.lblClassAttendence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 82);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanelClassAttendence
            // 
            this.tableLayoutPanelClassAttendence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelClassAttendence.ColumnCount = 2;
            this.tableLayoutPanelClassAttendence.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClassAttendence.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanelClassAttendence.Controls.Add(this.dtpDate, 1, 0);
            this.tableLayoutPanelClassAttendence.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanelClassAttendence.Location = new System.Drawing.Point(56, 116);
            this.tableLayoutPanelClassAttendence.Name = "tableLayoutPanelClassAttendence";
            this.tableLayoutPanelClassAttendence.RowCount = 1;
            this.tableLayoutPanelClassAttendence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClassAttendence.Size = new System.Drawing.Size(293, 45);
            this.tableLayoutPanelClassAttendence.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Location = new System.Drawing.Point(66, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(224, 20);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(10, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(278, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Attendence";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(12, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(12, 219);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(158, 31);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Information:";
            // 
            // picClassAttendence
            // 
            this.picClassAttendence.Image = ((System.Drawing.Image)(resources.GetObject("picClassAttendence.Image")));
            this.picClassAttendence.Location = new System.Drawing.Point(430, 12);
            this.picClassAttendence.Name = "picClassAttendence";
            this.picClassAttendence.Size = new System.Drawing.Size(117, 67);
            this.picClassAttendence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClassAttendence.TabIndex = 1;
            this.picClassAttendence.TabStop = false;
            // 
            // frmAttendenceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(559, 506);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanelClassAttendence);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvClassAttendence);
            this.Name = "frmAttendenceDetail";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AttendenceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassAttendence)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelClassAttendence.ResumeLayout(false);
            this.tableLayoutPanelClassAttendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClassAttendence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassAttendence;
        private System.Windows.Forms.DataGridView dgvClassAttendence;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClassAttendence;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picClassAttendence;
    }
}