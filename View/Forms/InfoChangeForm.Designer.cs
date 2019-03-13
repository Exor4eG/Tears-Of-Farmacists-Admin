namespace View.Forms
{
    partial class InfoChangeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.B_Change = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TB_Info, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.B_Change, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 253);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.TB_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Info.Location = new System.Drawing.Point(10, 10);
            this.TB_Info.Margin = new System.Windows.Forms.Padding(10);
            this.TB_Info.Multiline = true;
            this.TB_Info.Name = "textBox1";
            this.TB_Info.Size = new System.Drawing.Size(462, 163);
            this.TB_Info.TabIndex = 0;
            this.TB_Info.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // B_Change
            // 
            this.B_Change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_Change.Enabled = false;
            this.B_Change.Location = new System.Drawing.Point(100, 193);
            this.B_Change.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.B_Change.Name = "B_Change";
            this.B_Change.Size = new System.Drawing.Size(282, 40);
            this.B_Change.TabIndex = 1;
            this.B_Change.Text = "Изменить";
            this.B_Change.UseVisualStyleBackColor = true;
            this.B_Change.Click += new System.EventHandler(this.B_Change_Click);
            // 
            // InfoChangeForm
            // 
            this.AcceptButton = this.B_Change;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "InfoChangeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Изменения информации для фармацевтов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_Info;
        private System.Windows.Forms.Button B_Change;
    }
}