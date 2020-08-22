namespace ItemtypeModder
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.setClientLocationBtn = new System.Windows.Forms.Button();
            this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSelectedPath = new System.Windows.Forms.Label();
            this.btnStartModding = new System.Windows.Forms.Button();
            this.cbRefinated = new System.Windows.Forms.CheckBox();
            this.lblIdentifyItems = new System.Windows.Forms.Label();
            this.cbUnique = new System.Windows.Forms.CheckBox();
            this.cbElite = new System.Windows.Forms.CheckBox();
            this.cbSuper = new System.Windows.Forms.CheckBox();
            this.cbMoonboxTokens = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // setClientLocationBtn
            // 
            this.setClientLocationBtn.Location = new System.Drawing.Point(16, 26);
            this.setClientLocationBtn.Name = "setClientLocationBtn";
            this.setClientLocationBtn.Size = new System.Drawing.Size(448, 40);
            this.setClientLocationBtn.TabIndex = 0;
            this.setClientLocationBtn.Text = "Set Client Location";
            this.setClientLocationBtn.UseVisualStyleBackColor = true;
            this.setClientLocationBtn.Click += new System.EventHandler(this.SetClientLocationBtn_Click);
            // 
            // lblSelectedPath
            // 
            this.lblSelectedPath.AutoSize = true;
            this.lblSelectedPath.Location = new System.Drawing.Point(12, 152);
            this.lblSelectedPath.Name = "lblSelectedPath";
            this.lblSelectedPath.Size = new System.Drawing.Size(110, 20);
            this.lblSelectedPath.TabIndex = 1;
            this.lblSelectedPath.Text = "Not selected...";
            // 
            // btnStartModding
            // 
            this.btnStartModding.Location = new System.Drawing.Point(16, 84);
            this.btnStartModding.Name = "btnStartModding";
            this.btnStartModding.Size = new System.Drawing.Size(448, 45);
            this.btnStartModding.TabIndex = 2;
            this.btnStartModding.Text = "Start Modding itemtype";
            this.btnStartModding.UseVisualStyleBackColor = true;
            this.btnStartModding.Click += new System.EventHandler(this.BtnStartModding_Click);
            // 
            // cbRefinated
            // 
            this.cbRefinated.AutoSize = true;
            this.cbRefinated.Location = new System.Drawing.Point(663, 26);
            this.cbRefinated.Name = "cbRefinated";
            this.cbRefinated.Size = new System.Drawing.Size(91, 24);
            this.cbRefinated.TabIndex = 3;
            this.cbRefinated.Text = "Refined";
            this.cbRefinated.UseVisualStyleBackColor = true;
            // 
            // lblIdentifyItems
            // 
            this.lblIdentifyItems.AutoSize = true;
            this.lblIdentifyItems.Font = new System.Drawing.Font("Caladea", 9.999999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifyItems.Location = new System.Drawing.Point(512, 24);
            this.lblIdentifyItems.Name = "lblIdentifyItems";
            this.lblIdentifyItems.Size = new System.Drawing.Size(128, 23);
            this.lblIdentifyItems.TabIndex = 4;
            this.lblIdentifyItems.Text = "Identify Items:";
            // 
            // cbUnique
            // 
            this.cbUnique.AutoSize = true;
            this.cbUnique.Location = new System.Drawing.Point(760, 26);
            this.cbUnique.Name = "cbUnique";
            this.cbUnique.Size = new System.Drawing.Size(86, 24);
            this.cbUnique.TabIndex = 5;
            this.cbUnique.Text = "Unique";
            this.cbUnique.UseVisualStyleBackColor = true;
            // 
            // cbElite
            // 
            this.cbElite.AutoSize = true;
            this.cbElite.Location = new System.Drawing.Point(852, 26);
            this.cbElite.Name = "cbElite";
            this.cbElite.Size = new System.Drawing.Size(66, 24);
            this.cbElite.TabIndex = 6;
            this.cbElite.Text = "Elite";
            this.cbElite.UseVisualStyleBackColor = true;
            // 
            // cbSuper
            // 
            this.cbSuper.AutoSize = true;
            this.cbSuper.Location = new System.Drawing.Point(924, 26);
            this.cbSuper.Name = "cbSuper";
            this.cbSuper.Size = new System.Drawing.Size(78, 24);
            this.cbSuper.TabIndex = 7;
            this.cbSuper.Text = "Super";
            this.cbSuper.UseVisualStyleBackColor = true;
            // 
            // cbMoonboxTokens
            // 
            this.cbMoonboxTokens.AutoSize = true;
            this.cbMoonboxTokens.Location = new System.Drawing.Point(663, 66);
            this.cbMoonboxTokens.Name = "cbMoonboxTokens";
            this.cbMoonboxTokens.Size = new System.Drawing.Size(292, 24);
            this.cbMoonboxTokens.TabIndex = 8;
            this.cbMoonboxTokens.Text = "Command Tokens (MoonBox Quest)";
            this.cbMoonboxTokens.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 181);
            this.Controls.Add(this.cbMoonboxTokens);
            this.Controls.Add(this.cbSuper);
            this.Controls.Add(this.cbElite);
            this.Controls.Add(this.cbUnique);
            this.Controls.Add(this.lblIdentifyItems);
            this.Controls.Add(this.cbRefinated);
            this.Controls.Add(this.btnStartModding);
            this.Controls.Add(this.lblSelectedPath);
            this.Controls.Add(this.setClientLocationBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Itemtype Modder (Conquer Online)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setClientLocationBtn;
        private System.Windows.Forms.FolderBrowserDialog browserDialog;
        private System.Windows.Forms.Label lblSelectedPath;
        private System.Windows.Forms.Button btnStartModding;
        private System.Windows.Forms.CheckBox cbRefinated;
        private System.Windows.Forms.Label lblIdentifyItems;
        private System.Windows.Forms.CheckBox cbUnique;
        private System.Windows.Forms.CheckBox cbElite;
        private System.Windows.Forms.CheckBox cbSuper;
        private System.Windows.Forms.CheckBox cbMoonboxTokens;
    }
}

