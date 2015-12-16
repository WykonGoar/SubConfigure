namespace SubConfigure
{
    partial class Home
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
            this.bImport = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.gbStylesEvents = new System.Windows.Forms.GroupBox();
            this.gbMoveEventTimes = new System.Windows.Forms.GroupBox();
            this.mtbEndRegion = new System.Windows.Forms.MaskedTextBox();
            this.mtbStartRegion = new System.Windows.Forms.MaskedTextBox();
            this.tbMove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvASSScriptInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvASSEvents = new System.Windows.Forms.DataGridView();
            this.dgvASSStyles = new System.Windows.Forms.DataGridView();
            this.gbStylesEvents.SuspendLayout();
            this.gbMoveEventTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASSScriptInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASSEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASSStyles)).BeginInit();
            this.SuspendLayout();
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(12, 8);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 0;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(93, 8);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(75, 23);
            this.bExport.TabIndex = 1;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // gbStylesEvents
            // 
            this.gbStylesEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStylesEvents.Controls.Add(this.gbMoveEventTimes);
            this.gbStylesEvents.Controls.Add(this.label3);
            this.gbStylesEvents.Controls.Add(this.dgvASSScriptInfo);
            this.gbStylesEvents.Controls.Add(this.label2);
            this.gbStylesEvents.Controls.Add(this.label1);
            this.gbStylesEvents.Controls.Add(this.dgvASSEvents);
            this.gbStylesEvents.Controls.Add(this.dgvASSStyles);
            this.gbStylesEvents.Location = new System.Drawing.Point(12, 37);
            this.gbStylesEvents.MinimumSize = new System.Drawing.Size(685, 359);
            this.gbStylesEvents.Name = "gbStylesEvents";
            this.gbStylesEvents.Size = new System.Drawing.Size(685, 359);
            this.gbStylesEvents.TabIndex = 4;
            this.gbStylesEvents.TabStop = false;
            // 
            // gbMoveEventTimes
            // 
            this.gbMoveEventTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMoveEventTimes.Controls.Add(this.mtbEndRegion);
            this.gbMoveEventTimes.Controls.Add(this.mtbStartRegion);
            this.gbMoveEventTimes.Controls.Add(this.tbMove);
            this.gbMoveEventTimes.Controls.Add(this.label6);
            this.gbMoveEventTimes.Controls.Add(this.label4);
            this.gbMoveEventTimes.Controls.Add(this.nudTime);
            this.gbMoveEventTimes.Controls.Add(this.label5);
            this.gbMoveEventTimes.Location = new System.Drawing.Point(489, 32);
            this.gbMoveEventTimes.Name = "gbMoveEventTimes";
            this.gbMoveEventTimes.Size = new System.Drawing.Size(142, 150);
            this.gbMoveEventTimes.TabIndex = 13;
            this.gbMoveEventTimes.TabStop = false;
            this.gbMoveEventTimes.Text = "Move event  times";
            // 
            // mtbEndRegion
            // 
            this.mtbEndRegion.Location = new System.Drawing.Point(64, 57);
            this.mtbEndRegion.Mask = "0:00:00.00";
            this.mtbEndRegion.Name = "mtbEndRegion";
            this.mtbEndRegion.Size = new System.Drawing.Size(66, 20);
            this.mtbEndRegion.TabIndex = 14;
            // 
            // mtbStartRegion
            // 
            this.mtbStartRegion.Location = new System.Drawing.Point(64, 31);
            this.mtbStartRegion.Mask = "0:00:00.00";
            this.mtbStartRegion.Name = "mtbStartRegion";
            this.mtbStartRegion.Size = new System.Drawing.Size(66, 20);
            this.mtbStartRegion.TabIndex = 13;
            // 
            // tbMove
            // 
            this.tbMove.Location = new System.Drawing.Point(9, 111);
            this.tbMove.Name = "tbMove";
            this.tbMove.Size = new System.Drawing.Size(121, 23);
            this.tbMove.TabIndex = 12;
            this.tbMove.Text = "Move";
            this.tbMove.UseVisualStyleBackColor = true;
            this.tbMove.Click += new System.EventHandler(this.tbMove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time (ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start";
            // 
            // nudTime
            // 
            this.nudTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTime.Location = new System.Drawing.Point(64, 84);
            this.nudTime.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(66, 20);
            this.nudTime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Script info";
            // 
            // dgvASSScriptInfo
            // 
            this.dgvASSScriptInfo.AllowUserToAddRows = false;
            this.dgvASSScriptInfo.AllowUserToOrderColumns = true;
            this.dgvASSScriptInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvASSScriptInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvASSScriptInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASSScriptInfo.Location = new System.Drawing.Point(432, 201);
            this.dgvASSScriptInfo.Name = "dgvASSScriptInfo";
            this.dgvASSScriptInfo.Size = new System.Drawing.Size(247, 150);
            this.dgvASSScriptInfo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Styles";
            // 
            // dgvASSEvents
            // 
            this.dgvASSEvents.AllowUserToOrderColumns = true;
            this.dgvASSEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvASSEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvASSEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASSEvents.Location = new System.Drawing.Point(6, 201);
            this.dgvASSEvents.Name = "dgvASSEvents";
            this.dgvASSEvents.Size = new System.Drawing.Size(420, 150);
            this.dgvASSEvents.TabIndex = 1;
            // 
            // dgvASSStyles
            // 
            this.dgvASSStyles.AllowUserToOrderColumns = true;
            this.dgvASSStyles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvASSStyles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvASSStyles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASSStyles.Location = new System.Drawing.Point(6, 32);
            this.dgvASSStyles.Name = "dgvASSStyles";
            this.dgvASSStyles.Size = new System.Drawing.Size(420, 150);
            this.dgvASSStyles.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 407);
            this.Controls.Add(this.gbStylesEvents);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.bImport);
            this.MinimumSize = new System.Drawing.Size(722, 446);
            this.Name = "Home";
            this.Text = "SubConfigure";
            this.gbStylesEvents.ResumeLayout(false);
            this.gbStylesEvents.PerformLayout();
            this.gbMoveEventTimes.ResumeLayout(false);
            this.gbMoveEventTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASSScriptInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASSEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASSStyles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.GroupBox gbStylesEvents;
        private System.Windows.Forms.DataGridView dgvASSEvents;
        private System.Windows.Forms.DataGridView dgvASSStyles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvASSScriptInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMoveEventTimes;
        private System.Windows.Forms.Button tbMove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbEndRegion;
        private System.Windows.Forms.MaskedTextBox mtbStartRegion;
    }
}

