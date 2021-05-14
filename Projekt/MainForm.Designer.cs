namespace Projekt
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonTran = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.Transparent;
            this.buttonAuto.BackgroundImage = global::Projekt.Properties.Resources.iAuto;
            this.buttonAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAuto.Location = new System.Drawing.Point(620, 292);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(177, 109);
            this.buttonAuto.TabIndex = 0;
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonTran
            // 
            this.buttonTran.BackColor = System.Drawing.Color.Transparent;
            this.buttonTran.BackgroundImage = global::Projekt.Properties.Resources.iTramwaj;
            this.buttonTran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTran.Location = new System.Drawing.Point(122, 292);
            this.buttonTran.Name = "buttonTran";
            this.buttonTran.Size = new System.Drawing.Size(179, 109);
            this.buttonTran.TabIndex = 1;
            this.buttonTran.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(143, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tramwaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(645, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autobusy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.tlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTran);
            this.Controls.Add(this.buttonAuto);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Rozkład Jazdy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonTran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

