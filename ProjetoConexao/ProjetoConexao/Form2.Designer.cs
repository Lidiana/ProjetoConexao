namespace ProjetoConexao
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.tbUFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdTesteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdTesteDataSet = new ProjetoConexao.bdTesteDataSet();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.tbCidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUFTableAdapter = new ProjetoConexao.bdTesteDataSetTableAdapters.tbUFTableAdapter();
            this.tbCidadeTableAdapter = new ProjetoConexao.bdTesteDataSetTableAdapters.tbCidadeTableAdapter();
            this.bdTesteDataSet1 = new ProjetoConexao.bdTesteDataSet1();
            this.tbCidadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCidadeTableAdapter1 = new ProjetoConexao.bdTesteDataSet1TableAdapters.tbCidadeTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bdTesteDataSet2 = new ProjetoConexao.bdTesteDataSet2();
            this.tbCidadeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCidadeTableAdapter2 = new ProjetoConexao.bdTesteDataSet2TableAdapters.tbCidadeTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbUFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCidadeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCidadeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.DataSource = this.tbUFBindingSource;
            this.cboEstado.DisplayMember = "UF";
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(122, 51);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 2;
            this.cboEstado.ValueMember = "Estado";
            // 
            // tbUFBindingSource
            // 
            this.tbUFBindingSource.DataMember = "tbUF";
            this.tbUFBindingSource.DataSource = this.bdTesteDataSetBindingSource;
            // 
            // bdTesteDataSetBindingSource
            // 
            this.bdTesteDataSetBindingSource.DataSource = this.bdTesteDataSet;
            this.bdTesteDataSetBindingSource.Position = 0;
            // 
            // bdTesteDataSet
            // 
            this.bdTesteDataSet.DataSetName = "bdTesteDataSet";
            this.bdTesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboCidade
            // 
            this.cboCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbUFBindingSource, "UF", true));
            this.cboCidade.DataSource = this.tbCidadeBindingSource;
            this.cboCidade.DisplayMember = "Cidade";
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(581, 51);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(121, 21);
            this.cboCidade.TabIndex = 3;
            this.cboCidade.ValueMember = "idCidade";
            // 
            // tbCidadeBindingSource
            // 
            this.tbCidadeBindingSource.DataMember = "tbCidade";
            this.tbCidadeBindingSource.DataSource = this.bdTesteDataSetBindingSource;
            // 
            // tbUFTableAdapter
            // 
            this.tbUFTableAdapter.ClearBeforeFill = true;
            // 
            // tbCidadeTableAdapter
            // 
            this.tbCidadeTableAdapter.ClearBeforeFill = true;
            // 
            // bdTesteDataSet1
            // 
            this.bdTesteDataSet1.DataSetName = "bdTesteDataSet1";
            this.bdTesteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCidadeBindingSource1
            // 
            this.tbCidadeBindingSource1.DataMember = "tbCidade";
            this.tbCidadeBindingSource1.DataSource = this.bdTesteDataSet1;
            // 
            // tbCidadeTableAdapter1
            // 
            this.tbCidadeTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbCidadeBindingSource2;
            this.comboBox1.DisplayMember = "Cidade";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "idCidade";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bdTesteDataSet2
            // 
            this.bdTesteDataSet2.DataSetName = "bdTesteDataSet2";
            this.bdTesteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCidadeBindingSource2
            // 
            this.tbCidadeBindingSource2.DataMember = "tbCidade";
            this.tbCidadeBindingSource2.DataSource = this.bdTesteDataSet2;
            // 
            // tbCidadeTableAdapter2
            // 
            this.tbCidadeTableAdapter2.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbUFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCidadeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTesteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCidadeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.BindingSource bdTesteDataSetBindingSource;
        private bdTesteDataSet bdTesteDataSet;
        private System.Windows.Forms.BindingSource tbUFBindingSource;
        private bdTesteDataSetTableAdapters.tbUFTableAdapter tbUFTableAdapter;
        private System.Windows.Forms.BindingSource tbCidadeBindingSource;
        private bdTesteDataSetTableAdapters.tbCidadeTableAdapter tbCidadeTableAdapter;
        private bdTesteDataSet1 bdTesteDataSet1;
        private System.Windows.Forms.BindingSource tbCidadeBindingSource1;
        private bdTesteDataSet1TableAdapters.tbCidadeTableAdapter tbCidadeTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private bdTesteDataSet2 bdTesteDataSet2;
        private System.Windows.Forms.BindingSource tbCidadeBindingSource2;
        private bdTesteDataSet2TableAdapters.tbCidadeTableAdapter tbCidadeTableAdapter2;
        private System.Windows.Forms.Label label3;
    }
}