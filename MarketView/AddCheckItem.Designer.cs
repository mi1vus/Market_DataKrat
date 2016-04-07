namespace MarketView
{
    partial class AddCheckItem
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
            this.CommonTLP = new System.Windows.Forms.TableLayoutPanel();
            this.GoodPriceTlp = new System.Windows.Forms.TableLayoutPanel();
            this.GoodPriceValueLbl = new System.Windows.Forms.Label();
            this.GoodPriceLbl = new System.Windows.Forms.Label();
            this.ButtonsTLP = new System.Windows.Forms.TableLayoutPanel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.BarCodeTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BarCodeLbl = new System.Windows.Forms.Label();
            this.BarCodeTB = new System.Windows.Forms.TextBox();
            this.GoodNameTLP = new System.Windows.Forms.TableLayoutPanel();
            this.GoodNameValueLbl = new System.Windows.Forms.Label();
            this.GoodNameLab = new System.Windows.Forms.Label();
            this.GoodBS = new System.Windows.Forms.BindingSource(this.components);
            this.CommonTLP.SuspendLayout();
            this.GoodPriceTlp.SuspendLayout();
            this.ButtonsTLP.SuspendLayout();
            this.BarCodeTLP.SuspendLayout();
            this.GoodNameTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodBS)).BeginInit();
            this.SuspendLayout();
            // 
            // CommonTLP
            // 
            this.CommonTLP.ColumnCount = 1;
            this.CommonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CommonTLP.Controls.Add(this.GoodPriceTlp, 0, 2);
            this.CommonTLP.Controls.Add(this.ButtonsTLP, 0, 3);
            this.CommonTLP.Controls.Add(this.BarCodeTLP, 0, 0);
            this.CommonTLP.Controls.Add(this.GoodNameTLP, 0, 1);
            this.CommonTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommonTLP.Location = new System.Drawing.Point(0, 0);
            this.CommonTLP.Name = "CommonTLP";
            this.CommonTLP.RowCount = 4;
            this.CommonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CommonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CommonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CommonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.CommonTLP.Size = new System.Drawing.Size(482, 205);
            this.CommonTLP.TabIndex = 0;
            // 
            // GoodPriceTlp
            // 
            this.GoodPriceTlp.ColumnCount = 2;
            this.GoodPriceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.GoodPriceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GoodPriceTlp.Controls.Add(this.GoodPriceValueLbl, 0, 0);
            this.GoodPriceTlp.Controls.Add(this.GoodPriceLbl, 0, 0);
            this.GoodPriceTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoodPriceTlp.Location = new System.Drawing.Point(3, 85);
            this.GoodPriceTlp.Name = "GoodPriceTlp";
            this.GoodPriceTlp.RowCount = 1;
            this.GoodPriceTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GoodPriceTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.GoodPriceTlp.Size = new System.Drawing.Size(476, 35);
            this.GoodPriceTlp.TabIndex = 3;
            // 
            // GoodPriceValueLbl
            // 
            this.GoodPriceValueLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GoodPriceValueLbl.AutoSize = true;
            this.GoodPriceValueLbl.Location = new System.Drawing.Point(133, 9);
            this.GoodPriceValueLbl.Name = "GoodPriceValueLbl";
            this.GoodPriceValueLbl.Size = new System.Drawing.Size(31, 17);
            this.GoodPriceValueLbl.TabIndex = 1;
            this.GoodPriceValueLbl.Text = "нет";
            // 
            // GoodPriceLbl
            // 
            this.GoodPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GoodPriceLbl.AutoSize = true;
            this.GoodPriceLbl.Location = new System.Drawing.Point(3, 9);
            this.GoodPriceLbl.Name = "GoodPriceLbl";
            this.GoodPriceLbl.Size = new System.Drawing.Size(93, 17);
            this.GoodPriceLbl.TabIndex = 0;
            this.GoodPriceLbl.Text = "Цена товара";
            // 
            // ButtonsTLP
            // 
            this.ButtonsTLP.ColumnCount = 2;
            this.ButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTLP.Controls.Add(this.AddBtn, 0, 0);
            this.ButtonsTLP.Controls.Add(this.CancelBtn, 1, 0);
            this.ButtonsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTLP.Location = new System.Drawing.Point(3, 126);
            this.ButtonsTLP.Name = "ButtonsTLP";
            this.ButtonsTLP.RowCount = 1;
            this.ButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTLP.Size = new System.Drawing.Size(476, 76);
            this.ButtonsTLP.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddBtn.Enabled = false;
            this.AddBtn.Location = new System.Drawing.Point(78, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(82, 70);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить товар";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelBtn.Location = new System.Drawing.Point(316, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(81, 70);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // BarCodeTLP
            // 
            this.BarCodeTLP.ColumnCount = 2;
            this.BarCodeTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.BarCodeTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BarCodeTLP.Controls.Add(this.BarCodeLbl, 0, 0);
            this.BarCodeTLP.Controls.Add(this.BarCodeTB, 1, 0);
            this.BarCodeTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarCodeTLP.Location = new System.Drawing.Point(3, 3);
            this.BarCodeTLP.Name = "BarCodeTLP";
            this.BarCodeTLP.RowCount = 1;
            this.BarCodeTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BarCodeTLP.Size = new System.Drawing.Size(476, 35);
            this.BarCodeTLP.TabIndex = 1;
            // 
            // BarCodeLbl
            // 
            this.BarCodeLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BarCodeLbl.AutoSize = true;
            this.BarCodeLbl.Location = new System.Drawing.Point(3, 9);
            this.BarCodeLbl.Name = "BarCodeLbl";
            this.BarCodeLbl.Size = new System.Drawing.Size(75, 17);
            this.BarCodeLbl.TabIndex = 0;
            this.BarCodeLbl.Text = "Штрих код";
            // 
            // BarCodeTB
            // 
            this.BarCodeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BarCodeTB.Location = new System.Drawing.Point(133, 6);
            this.BarCodeTB.Name = "BarCodeTB";
            this.BarCodeTB.Size = new System.Drawing.Size(340, 22);
            this.BarCodeTB.TabIndex = 1;
            this.BarCodeTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarCodeTB_KeyDown);
            // 
            // GoodNameTLP
            // 
            this.GoodNameTLP.ColumnCount = 2;
            this.GoodNameTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.GoodNameTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GoodNameTLP.Controls.Add(this.GoodNameValueLbl, 0, 0);
            this.GoodNameTLP.Controls.Add(this.GoodNameLab, 0, 0);
            this.GoodNameTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoodNameTLP.Location = new System.Drawing.Point(3, 44);
            this.GoodNameTLP.Name = "GoodNameTLP";
            this.GoodNameTLP.RowCount = 1;
            this.GoodNameTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GoodNameTLP.Size = new System.Drawing.Size(476, 35);
            this.GoodNameTLP.TabIndex = 2;
            // 
            // GoodNameValueLbl
            // 
            this.GoodNameValueLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GoodNameValueLbl.AutoSize = true;
            this.GoodNameValueLbl.Location = new System.Drawing.Point(133, 9);
            this.GoodNameValueLbl.Name = "GoodNameValueLbl";
            this.GoodNameValueLbl.Size = new System.Drawing.Size(31, 17);
            this.GoodNameValueLbl.TabIndex = 1;
            this.GoodNameValueLbl.Text = "нет";
            // 
            // GoodNameLab
            // 
            this.GoodNameLab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GoodNameLab.AutoSize = true;
            this.GoodNameLab.Location = new System.Drawing.Point(3, 9);
            this.GoodNameLab.Name = "GoodNameLab";
            this.GoodNameLab.Size = new System.Drawing.Size(122, 17);
            this.GoodNameLab.TabIndex = 0;
            this.GoodNameLab.Text = "Название товара";
            // 
            // AddCheckItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 205);
            this.Controls.Add(this.CommonTLP);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "AddCheckItem";
            this.Text = "AddCheckItem";
            this.CommonTLP.ResumeLayout(false);
            this.GoodPriceTlp.ResumeLayout(false);
            this.GoodPriceTlp.PerformLayout();
            this.ButtonsTLP.ResumeLayout(false);
            this.BarCodeTLP.ResumeLayout(false);
            this.BarCodeTLP.PerformLayout();
            this.GoodNameTLP.ResumeLayout(false);
            this.GoodNameTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CommonTLP;
        private System.Windows.Forms.TableLayoutPanel ButtonsTLP;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TableLayoutPanel BarCodeTLP;
        private System.Windows.Forms.Label BarCodeLbl;
        private System.Windows.Forms.TextBox BarCodeTB;
        private System.Windows.Forms.BindingSource GoodBS;
        private System.Windows.Forms.TableLayoutPanel GoodNameTLP;
        private System.Windows.Forms.Label GoodNameLab;
        private System.Windows.Forms.TableLayoutPanel GoodPriceTlp;
        private System.Windows.Forms.Label GoodPriceLbl;
        private System.Windows.Forms.Label GoodPriceValueLbl;
        private System.Windows.Forms.Label GoodNameValueLbl;
    }
}