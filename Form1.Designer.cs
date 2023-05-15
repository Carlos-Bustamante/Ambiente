namespace ambiente
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
            this.groupBoxDirectory = new System.Windows.Forms.GroupBox();
            this.MenuDirectory = new System.Windows.Forms.Button();
            this.LabelDirectory = new System.Windows.Forms.TextBox();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.buttonEncripter = new System.Windows.Forms.Button();
            this.textBoxEncripter = new System.Windows.Forms.TextBox();
            this.labelEncripter = new System.Windows.Forms.Label();
            this.buttonPackage = new System.Windows.Forms.Button();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.labelPackage = new System.Windows.Forms.Label();
            this.buttonActualizador = new System.Windows.Forms.Button();
            this.textBoxActualicer = new System.Windows.Forms.TextBox();
            this.labelActualizador = new System.Windows.Forms.Label();
            this.groupBoxAgent = new System.Windows.Forms.GroupBox();
            this.checkBoxAgente920 = new System.Windows.Forms.CheckBox();
            this.checkBoxAgente880 = new System.Windows.Forms.CheckBox();
            this.checkBoxAgente800 = new System.Windows.Forms.CheckBox();
            this.checkBoxAgente600 = new System.Windows.Forms.CheckBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.groupBoxDirectory.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxAgent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDirectory
            // 
            this.groupBoxDirectory.Controls.Add(this.MenuDirectory);
            this.groupBoxDirectory.Controls.Add(this.LabelDirectory);
            this.groupBoxDirectory.Location = new System.Drawing.Point(27, 12);
            this.groupBoxDirectory.Name = "groupBoxDirectory";
            this.groupBoxDirectory.Size = new System.Drawing.Size(729, 87);
            this.groupBoxDirectory.TabIndex = 0;
            this.groupBoxDirectory.TabStop = false;
            this.groupBoxDirectory.Text = "Directory";
            // 
            // MenuDirectory
            // 
            this.MenuDirectory.Location = new System.Drawing.Point(515, 30);
            this.MenuDirectory.Name = "MenuDirectory";
            this.MenuDirectory.Size = new System.Drawing.Size(157, 27);
            this.MenuDirectory.TabIndex = 1;
            this.MenuDirectory.Text = "...";
            this.MenuDirectory.UseVisualStyleBackColor = true;
            this.MenuDirectory.Click += new System.EventHandler(this.MenuDirectory_Click);
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.Location = new System.Drawing.Point(20, 32);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(465, 22);
            this.LabelDirectory.TabIndex = 0;
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.buttonEncripter);
            this.groupBoxFile.Controls.Add(this.textBoxEncripter);
            this.groupBoxFile.Controls.Add(this.labelEncripter);
            this.groupBoxFile.Controls.Add(this.buttonPackage);
            this.groupBoxFile.Controls.Add(this.textBoxPackage);
            this.groupBoxFile.Controls.Add(this.labelPackage);
            this.groupBoxFile.Controls.Add(this.buttonActualizador);
            this.groupBoxFile.Controls.Add(this.textBoxActualicer);
            this.groupBoxFile.Controls.Add(this.labelActualizador);
            this.groupBoxFile.Location = new System.Drawing.Point(27, 145);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(381, 179);
            this.groupBoxFile.TabIndex = 1;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "File";
            // 
            // buttonEncripter
            // 
            this.buttonEncripter.Location = new System.Drawing.Point(346, 139);
            this.buttonEncripter.Name = "buttonEncripter";
            this.buttonEncripter.Size = new System.Drawing.Size(29, 23);
            this.buttonEncripter.TabIndex = 8;
            this.buttonEncripter.Text = "...";
            this.buttonEncripter.UseVisualStyleBackColor = true;
            this.buttonEncripter.Click += new System.EventHandler(this.buttonEncripter_Click);
            // 
            // textBoxEncripter
            // 
            this.textBoxEncripter.Location = new System.Drawing.Point(20, 139);
            this.textBoxEncripter.Name = "textBoxEncripter";
            this.textBoxEncripter.Size = new System.Drawing.Size(320, 22);
            this.textBoxEncripter.TabIndex = 7;
            // 
            // labelEncripter
            // 
            this.labelEncripter.AutoSize = true;
            this.labelEncripter.Location = new System.Drawing.Point(17, 120);
            this.labelEncripter.Name = "labelEncripter";
            this.labelEncripter.Size = new System.Drawing.Size(60, 16);
            this.labelEncripter.TabIndex = 6;
            this.labelEncripter.Text = "Encripter";
            // 
            // buttonPackage
            // 
            this.buttonPackage.Location = new System.Drawing.Point(346, 94);
            this.buttonPackage.Name = "buttonPackage";
            this.buttonPackage.Size = new System.Drawing.Size(29, 23);
            this.buttonPackage.TabIndex = 5;
            this.buttonPackage.Text = "...";
            this.buttonPackage.UseVisualStyleBackColor = true;
            this.buttonPackage.Click += new System.EventHandler(this.buttonPackage_Click);
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Location = new System.Drawing.Point(20, 94);
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.Size = new System.Drawing.Size(320, 22);
            this.textBoxPackage.TabIndex = 4;
            // 
            // labelPackage
            // 
            this.labelPackage.AutoSize = true;
            this.labelPackage.Location = new System.Drawing.Point(17, 75);
            this.labelPackage.Name = "labelPackage";
            this.labelPackage.Size = new System.Drawing.Size(62, 16);
            this.labelPackage.TabIndex = 3;
            this.labelPackage.Text = "Package";
            // 
            // buttonActualizador
            // 
            this.buttonActualizador.Location = new System.Drawing.Point(346, 46);
            this.buttonActualizador.Name = "buttonActualizador";
            this.buttonActualizador.Size = new System.Drawing.Size(29, 23);
            this.buttonActualizador.TabIndex = 2;
            this.buttonActualizador.Text = "...";
            this.buttonActualizador.UseVisualStyleBackColor = true;
            this.buttonActualizador.Click += new System.EventHandler(this.buttonActualizador_Click);
            // 
            // textBoxActualicer
            // 
            this.textBoxActualicer.Location = new System.Drawing.Point(20, 46);
            this.textBoxActualicer.Name = "textBoxActualicer";
            this.textBoxActualicer.Size = new System.Drawing.Size(320, 22);
            this.textBoxActualicer.TabIndex = 1;
            // 
            // labelActualizador
            // 
            this.labelActualizador.AutoSize = true;
            this.labelActualizador.Location = new System.Drawing.Point(17, 27);
            this.labelActualizador.Name = "labelActualizador";
            this.labelActualizador.Size = new System.Drawing.Size(66, 16);
            this.labelActualizador.TabIndex = 0;
            this.labelActualizador.Text = "Actualicer";
            // 
            // groupBoxAgent
            // 
            this.groupBoxAgent.Controls.Add(this.checkBoxAgente920);
            this.groupBoxAgent.Controls.Add(this.checkBoxAgente880);
            this.groupBoxAgent.Controls.Add(this.checkBoxAgente800);
            this.groupBoxAgent.Controls.Add(this.checkBoxAgente600);
            this.groupBoxAgent.Location = new System.Drawing.Point(428, 145);
            this.groupBoxAgent.Name = "groupBoxAgent";
            this.groupBoxAgent.Size = new System.Drawing.Size(328, 179);
            this.groupBoxAgent.TabIndex = 2;
            this.groupBoxAgent.TabStop = false;
            this.groupBoxAgent.Text = "Agent";
            // 
            // checkBoxAgente920
            // 
            this.checkBoxAgente920.AutoSize = true;
            this.checkBoxAgente920.Location = new System.Drawing.Point(199, 97);
            this.checkBoxAgente920.Name = "checkBoxAgente920";
            this.checkBoxAgente920.Size = new System.Drawing.Size(93, 20);
            this.checkBoxAgente920.TabIndex = 3;
            this.checkBoxAgente920.Text = "Agente920";
            this.checkBoxAgente920.UseVisualStyleBackColor = true;
            // 
            // checkBoxAgente880
            // 
            this.checkBoxAgente880.AutoSize = true;
            this.checkBoxAgente880.Location = new System.Drawing.Point(199, 37);
            this.checkBoxAgente880.Name = "checkBoxAgente880";
            this.checkBoxAgente880.Size = new System.Drawing.Size(93, 20);
            this.checkBoxAgente880.TabIndex = 2;
            this.checkBoxAgente880.Text = "Agente880";
            this.checkBoxAgente880.UseVisualStyleBackColor = true;
            // 
            // checkBoxAgente800
            // 
            this.checkBoxAgente800.AutoSize = true;
            this.checkBoxAgente800.Location = new System.Drawing.Point(28, 96);
            this.checkBoxAgente800.Name = "checkBoxAgente800";
            this.checkBoxAgente800.Size = new System.Drawing.Size(93, 20);
            this.checkBoxAgente800.TabIndex = 1;
            this.checkBoxAgente800.Text = "Agente800";
            this.checkBoxAgente800.UseVisualStyleBackColor = true;
            // 
            // checkBoxAgente600
            // 
            this.checkBoxAgente600.AutoSize = true;
            this.checkBoxAgente600.Location = new System.Drawing.Point(28, 37);
            this.checkBoxAgente600.Name = "checkBoxAgente600";
            this.checkBoxAgente600.Size = new System.Drawing.Size(93, 20);
            this.checkBoxAgente600.TabIndex = 0;
            this.checkBoxAgente600.Text = "Agente600";
            this.checkBoxAgente600.UseVisualStyleBackColor = true;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(298, 383);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(142, 30);
            this.Aceptar.TabIndex = 3;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.groupBoxAgent);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxDirectory);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WORLDSYS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDirectory.ResumeLayout(false);
            this.groupBoxDirectory.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxAgent.ResumeLayout(false);
            this.groupBoxAgent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDirectory;
        private System.Windows.Forms.Button MenuDirectory;
        private System.Windows.Forms.TextBox LabelDirectory;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxAgent;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.CheckBox checkBoxAgente920;
        private System.Windows.Forms.CheckBox checkBoxAgente880;
        private System.Windows.Forms.CheckBox checkBoxAgente800;
        private System.Windows.Forms.CheckBox checkBoxAgente600;
        private System.Windows.Forms.Button buttonEncripter;
        private System.Windows.Forms.TextBox textBoxEncripter;
        private System.Windows.Forms.Label labelEncripter;
        private System.Windows.Forms.Button buttonPackage;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.Label labelPackage;
        private System.Windows.Forms.Button buttonActualizador;
        private System.Windows.Forms.TextBox textBoxActualicer;
        private System.Windows.Forms.Label labelActualizador;
    }
}

