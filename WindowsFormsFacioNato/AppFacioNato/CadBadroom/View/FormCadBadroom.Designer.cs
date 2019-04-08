namespace AppFacioNato.CadBadroom.View
{
    partial class FormCadBadroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadBadroom));
            this.groupBoxCadInquilinoInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxCadInquilinoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCadInquilinoInfo
            // 
            this.groupBoxCadInquilinoInfo.Controls.Add(this.txtDescription);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblDescription);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.btnCancel);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.button2);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.txtName);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblName);
            this.groupBoxCadInquilinoInfo.Location = new System.Drawing.Point(26, 23);
            this.groupBoxCadInquilinoInfo.Name = "groupBoxCadInquilinoInfo";
            this.groupBoxCadInquilinoInfo.Size = new System.Drawing.Size(473, 330);
            this.groupBoxCadInquilinoInfo.TabIndex = 4;
            this.groupBoxCadInquilinoInfo.TabStop = false;
            this.groupBoxCadInquilinoInfo.Text = "Informações Cadastrais";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(124, 90);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 117);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(75, 17);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Descrição:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::WindowsFormsPrototipo.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(256, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnCancel.Size = new System.Drawing.Size(164, 74);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsPrototipo.Properties.Resources.save;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(50, 235);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(157, 74);
            this.button2.TabIndex = 0;
            this.button2.Text = "Gravar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 41);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCadBadroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 365);
            this.Controls.Add(this.groupBoxCadInquilinoInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadBadroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Quarto";
            this.groupBoxCadInquilinoInfo.ResumeLayout(false);
            this.groupBoxCadInquilinoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCadInquilinoInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}