namespace KTool.View
{
    partial class CpuCoreControl
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
            this.ckbEnable = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblNum = new MaterialSkin.Controls.MaterialLabel();
            this.txbNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // ckbEnable
            // 
            this.ckbEnable.AutoSize = true;
            this.ckbEnable.Depth = 0;
            this.ckbEnable.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbEnable.Location = new System.Drawing.Point(9, 87);
            this.ckbEnable.Margin = new System.Windows.Forms.Padding(0);
            this.ckbEnable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbEnable.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbEnable.Name = "ckbEnable";
            this.ckbEnable.Ripple = true;
            this.ckbEnable.Size = new System.Drawing.Size(217, 30);
            this.ckbEnable.TabIndex = 0;
            this.ckbEnable.Text = "Enable CPU core control";
            this.ckbEnable.UseVisualStyleBackColor = true;
            this.ckbEnable.CheckedChanged += new System.EventHandler(this.ckbEnable_CheckedChanged);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(259, 176);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(75, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Apply";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Depth = 0;
            this.lblNum.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNum.Location = new System.Drawing.Point(14, 127);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(139, 24);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Num of core(s)";
            // 
            // txbNum
            // 
            this.txbNum.Depth = 0;
            this.txbNum.Hint = "";
            this.txbNum.Location = new System.Drawing.Point(158, 127);
            this.txbNum.Margin = new System.Windows.Forms.Padding(2);
            this.txbNum.MaxLength = 32767;
            this.txbNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbNum.Name = "txbNum";
            this.txbNum.PasswordChar = '\0';
            this.txbNum.SelectedText = "";
            this.txbNum.SelectionLength = 0;
            this.txbNum.SelectionStart = 0;
            this.txbNum.Size = new System.Drawing.Size(178, 28);
            this.txbNum.TabIndex = 6;
            this.txbNum.TabStop = false;
            this.txbNum.UseSystemPasswordChar = false;
            // 
            // CpuCoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 235);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.ckbEnable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CpuCoreControl";
            this.Sizable = false;
            this.Text = "CPU Core Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox ckbEnable;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel lblNum;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbNum;
    }
}