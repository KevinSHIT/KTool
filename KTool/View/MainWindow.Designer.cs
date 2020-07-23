namespace KTool.View
{
    partial class MainWindow
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
            this.mtcCategory = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpNetwork = new System.Windows.Forms.TabPage();
            this.btnSyetemProxy = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbpSystem = new System.Windows.Forms.TabPage();
            this.btnCpuCoreControl = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mtcCategory.SuspendLayout();
            this.tbpNetwork.SuspendLayout();
            this.tbpSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtcCategory
            // 
            this.mtcCategory.Controls.Add(this.tbpNetwork);
            this.mtcCategory.Controls.Add(this.tbpSystem);
            this.mtcCategory.Depth = 0;
            this.mtcCategory.Location = new System.Drawing.Point(12, 113);
            this.mtcCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtcCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcCategory.Name = "mtcCategory";
            this.mtcCategory.SelectedIndex = 0;
            this.mtcCategory.Size = new System.Drawing.Size(776, 326);
            this.mtcCategory.TabIndex = 0;
            // 
            // tbpNetwork
            // 
            this.tbpNetwork.Controls.Add(this.btnSyetemProxy);
            this.tbpNetwork.Location = new System.Drawing.Point(4, 25);
            this.tbpNetwork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpNetwork.Name = "tbpNetwork";
            this.tbpNetwork.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpNetwork.Size = new System.Drawing.Size(768, 297);
            this.tbpNetwork.TabIndex = 0;
            this.tbpNetwork.Text = "Network";
            this.tbpNetwork.UseVisualStyleBackColor = true;
            // 
            // btnSyetemProxy
            // 
            this.btnSyetemProxy.AutoSize = true;
            this.btnSyetemProxy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSyetemProxy.Depth = 0;
            this.btnSyetemProxy.Icon = null;
            this.btnSyetemProxy.Location = new System.Drawing.Point(16, 7);
            this.btnSyetemProxy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSyetemProxy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSyetemProxy.Name = "btnSyetemProxy";
            this.btnSyetemProxy.Primary = false;
            this.btnSyetemProxy.Size = new System.Drawing.Size(148, 36);
            this.btnSyetemProxy.TabIndex = 0;
            this.btnSyetemProxy.Text = "System Proxy";
            this.btnSyetemProxy.UseVisualStyleBackColor = true;
            // 
            // tbpSystem
            // 
            this.tbpSystem.Controls.Add(this.btnCpuCoreControl);
            this.tbpSystem.Location = new System.Drawing.Point(4, 25);
            this.tbpSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSystem.Name = "tbpSystem";
            this.tbpSystem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSystem.Size = new System.Drawing.Size(768, 297);
            this.tbpSystem.TabIndex = 1;
            this.tbpSystem.Text = "System";
            this.tbpSystem.UseVisualStyleBackColor = true;
            // 
            // btnCpuCoreControl
            // 
            this.btnCpuCoreControl.AutoSize = true;
            this.btnCpuCoreControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCpuCoreControl.Depth = 0;
            this.btnCpuCoreControl.Icon = null;
            this.btnCpuCoreControl.Location = new System.Drawing.Point(7, 9);
            this.btnCpuCoreControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCpuCoreControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCpuCoreControl.Name = "btnCpuCoreControl";
            this.btnCpuCoreControl.Primary = false;
            this.btnCpuCoreControl.Size = new System.Drawing.Size(195, 36);
            this.btnCpuCoreControl.TabIndex = 0;
            this.btnCpuCoreControl.Text = "CPU Cores Control";
            this.btnCpuCoreControl.UseVisualStyleBackColor = true;
            this.btnCpuCoreControl.Click += new System.EventHandler(this.btnCpuCoreControl_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.mtcCategory;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 63);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(803, 46);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.mtcCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Sizable = false;
            this.Text = "KTool by Kevin Sanchez";
            this.mtcCategory.ResumeLayout(false);
            this.tbpNetwork.ResumeLayout(false);
            this.tbpNetwork.PerformLayout();
            this.tbpSystem.ResumeLayout(false);
            this.tbpSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtcCategory;
        private System.Windows.Forms.TabPage tbpNetwork;
        private System.Windows.Forms.TabPage tbpSystem;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton btnSyetemProxy;
        private MaterialSkin.Controls.MaterialFlatButton btnCpuCoreControl;
    }
}

