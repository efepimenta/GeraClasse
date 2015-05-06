using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeraClasse
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnConsertar_Click(object sender, EventArgs e)
        {
            //tem que ter um nome da classe
            if (edtNomeClasse.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome da classe não informado");
                edtNomeClasse.Focus();
                return;
                //o nome da classe nao pode conter espacos
            }
            else if (edtNomeClasse.Text.Contains(" "))
            {
                MessageBox.Show("Nome da classe não pode conter espaços");
                edtNomeClasse.Focus();
                return;
            }
            edtSaida.Clear();
            edtEntradaBunita.Clear();
            string linha = "";
            string linha_mae = "";
            int num;
            LblStatus.Text = "Fazendo a entrada ficar mais bonita...";
            pgbMain.Maximum = edtEntradaFeia.Lines.Length;
            pgbMain.Style = ProgressBarStyle.Continuous;
            for (int i = 0; i < edtEntradaFeia.Lines.Length; i++)
            {
                //pego o conteudo completo da linha
                linha = edtEntradaFeia.Lines[i].Trim();
                if (linha.Equals(""))
                    continue;
                if (linha.StartsWith("Minuta do Guia Prático"))
                    continue;
                else if (linha.StartsWith("Atualização:"))
                    continue;
                else if (linha.StartsWith("Página "))
                    continue;
                //vejo se começa com dois digitos numericos
                try
                {
                    //converto o primeiro digito pra inteiro
                    num = Convert.ToInt32(linha[0].ToString());
                    //converto o segundo digito pra inteiro
                    num = Convert.ToInt32(linha[1].ToString());
                    //se deu certo, verifico se o quinto caracter é um espaço em branco
                    if (linha[4].ToString().Equals(" "))
                    {
                        //se for siginica que nao é uma linha mae
                        linha_mae = linha_mae + linha + " ";
                    }
                    else
                    {
                        //se nao for, siginifica que é uma linha mae
                        //se terminar com O ou OC, siginfica que a linha esta completa
                        if (linha[linha.Length - 1].ToString().Equals("O") || linha[linha.Length - 1].ToString().Equals("C"))
                        {
                            //ja posso jogar pra saida
                            edtEntradaBunita.AppendText(linha.Trim() + "\n");
                        }
                        else
                        {
                            //se nao for preciso concatenar com linha mae
                            linha_mae = linha_mae + linha + " ";
                        }
                    }
                }
                //se falhou na conversao do primeiro ou do segundo digito, significa que nao é uma linha mae
                catch (Exception)
                {
                    //entao eu junto ela com a que ja existe
                    linha_mae = linha_mae + linha + " ";
                    //verifico se a linha esta completa, se tiver ja jogo na saida
                    if (linha[linha.Length - 1].ToString().Equals("O") || linha[linha.Length - 1].ToString().Equals("C"))
                    {
                        //ja posso jogar pra saida
                        edtEntradaBunita.AppendText(linha_mae.Trim() + "\n");
                        linha_mae = "";
                    }
                }
            }
            LblStatus.Text = "Entrada já esta melhor agora, pressione o botão Gerar";
            pgbMain.Style = ProgressBarStyle.Marquee;
            btnGerar.Enabled = true;
            if (chkAjudante.Checked)
            {
                btnGerar.PerformClick();
                btnCopiar.PerformClick();
                btnCopiar.Enabled = false;
                btnGerar.Enabled = false;
                btnNova.Enabled = false;
                edtSaida.Clear();
                edtNomeClasse.Text = "Registro_";
                edtEntradaFeia.Clear();
                edtEntradaBunita.Clear();
                edtDescricaoDaClasse.Clear();
                edtNomeClasse.Focus();
            }
        }

        private void chkSempreVisivel_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkSempreVisivel.Checked;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGerar_Click_1(object sender, EventArgs e)
        {
            edtSaida.Clear();
            /* criacao do sumario e cabecalho da classe */
            string DescClasse = "";
            for (int i = 0; i < edtDescricaoDaClasse.Lines.Length; i++)
            {
                DescClasse = DescClasse + edtDescricaoDaClasse.Lines[i].Trim() + " ";
            }
            string _sumario = String.Format("/// <summary>\n/// {0}\n/// </summary>\n", DescClasse.Trim());
            _sumario = _sumario + String.Format("public class {0}\n{{\n", edtNomeClasse.Text);
            edtSaida.AppendText(_sumario);

            /* lista com todos os campos encontrados */
            List<Campos> ListaDeCampos = new List<Campos>();

            for (int i = 0; i < edtEntradaBunita.Lines.Length; i++)
            {
                if (edtEntradaBunita.Lines[i].Trim().Equals(""))
                    continue;
                //quebramos a linha em 7 partes sendo:
                //Nº / Campo / Descrição / Tipo / Tam / Dec / Obrig (tem entrada e saida no lugar de obrigatorio em alguns casos)
                //desprezando a primeira parte, o Nº
                string _temp = edtEntradaBunita.Lines[i].Trim();
                int _fim = _temp.Trim().IndexOf(" ");
                _temp = _temp.Trim().Remove(0, _fim);
                _fim = _temp.Trim().IndexOf(" ");
                string _campo = _temp.Trim().Substring(0, _fim).Trim();

                _temp = _temp.Trim().Remove(0, _fim);
                _fim = _temp.IndexOf(" C ");
                string _tipo = "";
                if (_fim == -1)
                {
                    _fim = _temp.IndexOf(" N ");
                    _tipo = "int";
                }
                if (chkSoString.Checked)
                    _tipo = "string";

                string _descricao = _temp.Trim().Substring(0, _fim).Trim();
                string _valorDoCampo = "";
                _valorDoCampo = _descricao.Substring(_descricao.Length - 1, 1);
                if (_valorDoCampo.Equals("."))
                    _valorDoCampo = _descricao.Substring(_descricao.Length - 6, 4);
                else
                    _valorDoCampo = _descricao.Substring(_descricao.Length - 5, 4);

                _temp = _temp.Trim().Remove(0, _fim + 1);
                _fim = _temp.Trim().IndexOf(" ");
                string _tamanho = "";
                if (_tamanho.Length >= 3)
                    _tamanho = _temp.Trim().Substring(0, _fim).Trim().Substring(0, 3);
                else
                    _tamanho = _temp.Trim().Substring(0, _fim).Trim();

                _temp = _temp.Trim().Remove(0, _fim);
                if (_temp.Length < 4)
                    _temp = " - " + _temp;
                _fim = _temp.Trim().IndexOf(" ");
                string _decimais = _temp.Trim().Substring(0, _fim).Trim();

                string _obrigatorio = "";
                string _entrada = "";
                string _saida = "";
                if (rdNormal.Checked)
                {
                    //aqui entra a normal
                    _temp = _temp.Trim().Remove(0, _fim);
                    _fim = _temp.Trim().IndexOf(" ");
                    _obrigatorio = _temp.Trim();
                }
                else if (rdEntradaSaida.Checked)
                {
                    //aqui entra a entrada e saida
                    //sem saida = registro c120
                    //sem entrada = registro d400
                    string verificando = edtEntradaBunita.Lines[i].ToUpper();
                    if (verificando.Contains("NÃO APRESENTAR"))
                    {
                        //agora preciso descobrir se é entrada ou saida
                        if (verificando[verificando.Length - 1].ToString().Equals("O") || verificando[verificando.Length - 1].ToString().Equals("C"))
                        {
                            //esta na entrada porque a linha termina com O ou OC, entao adiciono um -
                            _temp = _temp.Remove(3, 14);
                            _temp = " - " + _temp;
                        }
                    }
                    else
                        _temp = " - " + _temp;
                    _temp = _temp.Trim().Remove(0, _fim);
                    _fim = _temp.Trim().IndexOf(" ");
                    _entrada = _temp.Trim().Substring(0, _fim);

                    _temp = _temp.Trim().Remove(0, _fim);
                    _fim = _temp.Trim().IndexOf(" ");
                    _saida = _temp.Trim();
                }
                else if (rdSaida.Checked)
                {
                    _temp = _temp.Trim().Remove(0, _fim);
                    _fim = _temp.Trim().IndexOf(" ");
                    _saida = _temp.Trim();
                }
                Campos campos = new Campos();
                campos.Campo = _campo;
                campos.Descricao = _descricao;
                campos.Tipo = _tipo;
                campos.Tamanho = _tamanho;
                campos.Casas_Decimais = _decimais;
                if (_obrigatorio.Equals("O"))
                    campos.Obrigatorio = true;
                else
                    campos.Obrigatorio = false;
                if (_entrada.Equals("O"))
                    campos.Entrada_Obrigatoria = true;
                else
                    campos.Entrada_Obrigatoria = false;
                if (_saida.Equals("O"))
                    campos.Saida_Obrigatoria = true;
                else
                    campos.Saida_Obrigatoria = false;
                ListaDeCampos.Add(campos);

                /* inicio da montagem da classe */

                string Saida = "";
                if (_tipo.Equals("string"))
                    if (_campo.Equals("REG"))
                        Saida = String.Format("private {0} F_{1} = \"{2}\";\n", _tipo, _campo, _valorDoCampo);
                    else
                        Saida = String.Format("private {0} F_{1} = \"\";\n", _tipo, _campo);
                else
                    Saida = String.Format("private {0} F_{1} = 0;\n", _tipo, _campo);
                //preencher o sumario
                Saida = Saida + String.Format("/// <summary>\n/// {0}\n/// </summary>\n", _descricao);
                //saida com o tipo string
                Saida = Saida + String.Format("public {0} {1} {{\n get {{ return F_{1}; }}\n set {{ F_{1} = value.ToUpper(); }} }}\n", _tipo, _campo);
                /* jogando a saida para a textbox */
                edtSaida.AppendText(Saida + "\n");
                Saida = Saida + String.Format("}}"); //fim do validate
            }

            /* criacao do metodo get */
            //inicio do validate
            string SaidaValidate = "";
            SaidaValidate = String.Format("public string Get{0}(bool Validate){{\n", edtNomeClasse.Text);
            SaidaValidate = SaidaValidate + String.Format("if (Validate){{\n");
            edtSaida.AppendText(SaidaValidate);

            //montagem das regras de validacao - acho que isso tem que ir pra dentro do rdNormal
            string validaTamanhoCampo = "";
            foreach (var _cp in ListaDeCampos)
            {
                //validacao do tamanho do campo
                int tm = 0; //tamanho do campo
                if (_cp.Tamanho.Length > 3)
                    _cp.Tamanho = _cp.Tamanho.Substring(0, 3);
                try
                {
                    tm = Convert.ToInt32(_cp.Tamanho);
                    validaTamanhoCampo = String.Format("/* validacao para o tamanho do campo {0} */\n", _cp.Campo);
                    string maximo = "";
                    for (int i = 0; i < Convert.ToInt32(_cp.Tamanho); i++)
                    {
                        maximo = maximo + "9"; //isso nao da certo em alguns casos, ultrapassa os valores de um inteiro
                    }
                    if (_cp.Tipo.Equals("string"))
                        validaTamanhoCampo = validaTamanhoCampo + String.Format("if (F_{0}.Length > {1}){{\n", _cp.Campo, tm);
                    else
                        validaTamanhoCampo = validaTamanhoCampo + String.Format("if (F_{0} > {1}){{\n", _cp.Campo, maximo); //ta errado, fazer direito
                    validaTamanhoCampo = validaTamanhoCampo + String.Format("return \"Erro -> Tamanho do campo de {0} incorreto(a)\";}}\n", _cp.Campo);
                }
                catch (Exception)
                {
                    tm = 0;
                }
                edtSaida.AppendText(validaTamanhoCampo);

                //validacao dos obrigatorios
                string ValidaObrigatorio = "";
                if (_cp.Obrigatorio || _cp.Entrada_Obrigatoria || _cp.Saida_Obrigatoria)
                {
                    ValidaObrigatorio = String.Format("/* validacao para a obrigatoriedade do campo {0} */\n", _cp.Campo);
                    if (_cp.Tipo.Equals("string"))
                        ValidaObrigatorio = ValidaObrigatorio + String.Format("if (F_{0}.Trim().Equals(\"\")){{\n", _cp.Campo, tm);
                    else
                        ValidaObrigatorio = ValidaObrigatorio + String.Format("if (F_{0} < 0){{\n", _cp.Campo);
                    ValidaObrigatorio = ValidaObrigatorio + String.Format("return \"Erro -> Campo Obrigatório {0} não informado(a)\";}}\n", _cp.Campo);
                    edtSaida.AppendText(ValidaObrigatorio);
                }

                //validacao milagrosa doa valores aceitos....                
                string _montando = "";
                string _saidaComDados = "";
                bool TemDados;
                TemDados = _cp.Descricao.Contains("- ");
                if (TemDados)
                {
                    List<string> dados = new List<string>();
                    string _tempDado = _cp.Descricao;
                    while (_tempDado.Contains("- "))
                    {
                        string _temp = "";
                        if (_tempDado.Substring(_tempDado.IndexOf("-") - 3, 2).Trim().Length > 1)
                            _temp = _tempDado.Substring(_tempDado.IndexOf("-") - 3, 2);
                        else
                            _temp = _tempDado.Substring(_tempDado.IndexOf("-") - 2, 2);
                        dados.Add(_temp.Trim());
                        _tempDado = _tempDado.Substring(_tempDado.IndexOf("-") + 1);
                        _temp = null;
                    }
                    for (int i = 0; i < dados.Count; i++)
                    {
                        if (_cp.Tipo.Equals("int"))
                            _montando = _montando + String.Format("F_{0} == {1} || ", _cp.Campo, dados[i].ToString());
                        else
                            _montando = _montando + String.Format("F_{0}.Equals(\"{1}\") ||", _cp.Campo.ToUpper(), dados[i].ToString().ToUpper());
                    }
                    _saidaComDados = String.Format("/* Validacao para os dados informados a {0} */", _cp.Campo);
                    _montando = "\n if ( !(" + _montando.Substring(0, _montando.Length - 3);
                    _saidaComDados = _saidaComDados + _montando + String.Format(")){{\n return \"Erro -> O campo {0} possui valores pré-definidos\";\n }}", _cp.Campo.ToUpper());
                    edtSaida.AppendText(_saidaComDados + "\n");
                }
                TemDados = _cp.Descricao.Contains(" -! ");
                if (TemDados)
                {
                    List<string> dados = new List<string>();
                    string _tempDado = _cp.Descricao;
                    while (_tempDado.Contains(" - "))
                    {
                        string _temp = _tempDado.Substring(_tempDado.IndexOf("-") - 3, 2);
                        dados.Add(_temp.Trim());
                        _tempDado = _tempDado.Substring(_tempDado.IndexOf("-") + 1);
                        _temp = null;
                    }
                    for (int i = 0; i < dados.Count; i++)
                    {
                        if (_cp.Tipo.Equals("int"))
                            _montando = _montando + String.Format("F_{0} == {1} || ", _cp.Campo, dados[i].ToString());
                        else
                            _montando = _montando + String.Format("F_{0}.Equals(\"{1}\") ||", _cp.Campo.ToUpper(), dados[i].ToString().ToUpper());
                    }
                    _saidaComDados = String.Format("/* Validacao dos dados passados a {0} */", _cp.Campo);
                    _montando = "\n if ( !(" + _montando.Substring(0, _montando.Length - 3);
                    _saidaComDados = _saidaComDados + _montando + String.Format(")){{\n return \"Erro -> O campo {0} possui valores pré-definidos\";\n }}", _cp.Campo.ToUpper());
                    edtSaida.AppendText(_saidaComDados + "\n");
                }
                TemDados = _cp.Descricao.Contains(" – ");
                if (TemDados)
                {
                    List<string> dados = new List<string>();
                    string _tempDado = _cp.Descricao;
                    while (_tempDado.Contains(" – "))
                    {
                        string _temp = _tempDado.Substring(_tempDado.IndexOf("–") - 3, 2);
                        dados.Add(_temp.Trim());
                        _tempDado = _tempDado.Substring(_tempDado.IndexOf("–") + 1);
                        _temp = null;
                    }
                    for (int i = 0; i < dados.Count; i++)
                    {
                        if (_cp.Tipo.Equals("int"))
                            _montando = _montando + String.Format("F_{0} == {1} || ", _cp.Campo, dados[i].ToString());
                        else
                            _montando = _montando + String.Format("F_{0}.Equals(\"{1}\") ||", _cp.Campo.ToUpper(), dados[i].ToString().ToUpper());
                    }
                    _saidaComDados = String.Format("/* Validacao dos dados passados a {0} */", _cp.Campo);
                    _montando = "\n if ( !(" + _montando.Substring(0, _montando.Length - 3);
                    _saidaComDados = _saidaComDados + _montando + String.Format(")){{\n return \"Erro -> O campo {0} possui valores pré-definidos\";\n }}", _cp.Campo.ToUpper());
                    edtSaida.AppendText(_saidaComDados + "\n");
                }
                TemDados = _cp.Descricao.Contains(" = ");
                if (TemDados)
                {
                    List<string> dados = new List<string>();
                    string _tempDado = _cp.Descricao;
                    while (_tempDado.Contains(" = "))
                    {
                        string _temp = _tempDado.Substring(_tempDado.IndexOf("=") - 3, 2);
                        dados.Add(_temp.Trim());
                        _tempDado = _tempDado.Substring(_tempDado.IndexOf("=") + 1);
                        _temp = null;
                    }
                    for (int i = 0; i < dados.Count; i++)
                    {
                        if (_cp.Tipo.Equals("int"))
                            _montando = _montando + String.Format("F_{0} == {1} || ", _cp.Campo, dados[i].ToString());
                        else
                            _montando = _montando + String.Format("F_{0}.Equals(\"{1}\") ||", _cp.Campo, dados[i].ToString());
                    }
                    _saidaComDados = String.Format("/* Validacao dos dados passados a {0} */", _cp.Campo);
                    _montando = "\n if ( !(" + _montando.Substring(0, _montando.Length - 3);
                    _saidaComDados = _saidaComDados + _montando + String.Format(")){{\n return \"Erro -> O campo {0} possui valores pré-definidos\";\n }}", _cp.Campo.ToUpper());
                    edtSaida.AppendText(_saidaComDados + "\n");
                }
                GC.Collect();
                //fim fo validate
            }
            edtSaida.AppendText("/* validacoes manuais */\n");
            edtSaida.AppendText("}\n");
            //inicio do return
            string ValidaReturn = "";
            string ValidaCampos = "";
            for (int i = 0; i < ListaDeCampos.Count; i++)
            {
                /* fazer a saida usando system.format */
                ValidaReturn = ValidaReturn + "|{" + i + "}";
                ValidaCampos = ValidaCampos + "F_" + ListaDeCampos[i].Campo + ",";
                // ValidaReturn = ValidaReturn + "\"|\" + F_" + ListaDeCampos[i].Campo + "+"; //versao antiga
            }
            ValidaReturn = "return String.Format(\"" + ValidaReturn + "|\"," + ValidaCampos.Substring(0, ValidaCampos.Length - 1) + ");\n}}";
            
            edtSaida.AppendText(ValidaReturn);
            //txtSaida.AppendText("\n return " + ValidaReturn.Substring(0, ValidaReturn.Length - 1) + ";"); //versao antiga
            //txtSaida.AppendText("}}");    //versao antiga
            btnCopiar.Enabled = true;
            ListaDeCampos = null;
            GC.Collect();
            LblStatus.Text = "Geração terminada, pode copiar agora...";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(edtSaida.Text);
            LblStatus.Text = "Tudo copiado, cola no lugar certo...";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
                btnCopiar.Enabled = false;
                btnGerar.Enabled = false;
                edtSaida.Clear();
                edtNomeClasse.Text = "Registro_";
                edtEntradaFeia.Clear();
                edtEntradaBunita.Clear();
                edtDescricaoDaClasse.Clear();
                edtNomeClasse.Focus();
                LblStatus.Text = "Pronto pra Recomeçar...";
        }
    }
}