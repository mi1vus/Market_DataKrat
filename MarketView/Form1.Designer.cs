namespace MarketView
{
    partial class MarketMainForm
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
            this.CreateBuyCheck = new System.Windows.Forms.Button();
            this.CreateReturnCheck = new System.Windows.Forms.Button();
            this.CancelCheck = new System.Windows.Forms.Button();
            this.SaveCheck = new System.Windows.Forms.Button();
            this.CheckBS = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBuyCheck
            // 
            this.CreateBuyCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateBuyCheck.Location = new System.Drawing.Point(3, 3);
            this.CreateBuyCheck.Name = "CreateBuyCheck";
            this.CreateBuyCheck.Size = new System.Drawing.Size(100, 65);
            this.CreateBuyCheck.TabIndex = 0;
            this.CreateBuyCheck.Text = "Открыть чек на покупку";
            this.CreateBuyCheck.UseVisualStyleBackColor = true;
            // 
            // CreateReturnCheck
            // 
            this.CreateReturnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateReturnCheck.Location = new System.Drawing.Point(109, 3);
            this.CreateReturnCheck.Name = "CreateReturnCheck";
            this.CreateReturnCheck.Size = new System.Drawing.Size(100, 65);
            this.CreateReturnCheck.TabIndex = 1;
            this.CreateReturnCheck.Text = "Открыть чек на возврат";
            this.CreateReturnCheck.UseVisualStyleBackColor = true;
            // 
            // CancelCheck
            // 
            this.CancelCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelCheck.Location = new System.Drawing.Point(215, 3);
            this.CancelCheck.Name = "CancelCheck";
            this.CancelCheck.Size = new System.Drawing.Size(100, 65);
            this.CancelCheck.TabIndex = 2;
            this.CancelCheck.Text = "Отменить чек";
            this.CancelCheck.UseVisualStyleBackColor = true;
            // 
            // SaveCheck
            // 
            this.SaveCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveCheck.Location = new System.Drawing.Point(321, 3);
            this.SaveCheck.Name = "SaveCheck";
            this.SaveCheck.Size = new System.Drawing.Size(102, 65);
            this.SaveCheck.TabIndex = 3;
            this.SaveCheck.Text = "Закрыть чек";
            this.SaveCheck.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.CreateBuyCheck, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveCheck, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreateReturnCheck, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelCheck, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.6383F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 71);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(432, 305);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // MarketMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 305);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "MarketMainForm";
            this.Text = "Market 0.1";
            this.Load += new System.EventHandler(this.MarketMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBuyCheck;
        private System.Windows.Forms.Button CreateReturnCheck;
        private System.Windows.Forms.Button CancelCheck;
        private System.Windows.Forms.Button SaveCheck;
        private System.Windows.Forms.BindingSource CheckBS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

