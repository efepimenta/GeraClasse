using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraClasse
{

    class Campos
    {
        private string F_CAMPO;
        private string F_DESCRICAO;
        private string F_TIPO;
        private string F_TAMANHO;
        private string F_DECIMAIS;
        private bool F_OBRIGATORIO;
        private bool F_ENTRADA;
        private bool F_SAIDA;

        public bool Saida_Obrigatoria
        {
            get { return F_SAIDA; }
            set { F_SAIDA = value; }
        }


        public bool Entrada_Obrigatoria
        {
            get { return F_ENTRADA; }
            set { F_ENTRADA = value; }
        }


        public bool Obrigatorio
        {
            get { return F_OBRIGATORIO; }
            set { F_OBRIGATORIO = value; }
        }


        public string Casas_Decimais
        {
            get { return F_DECIMAIS; }
            set { F_DECIMAIS = value; }
        }


        public string Tamanho
        {
            get { return F_TAMANHO; }
            set { F_TAMANHO = value; }
        }


        public string Tipo
        {
            get { return F_TIPO; }
            set { F_TIPO = value; }
        }


        public string Descricao
        {
            get { return F_DESCRICAO; }
            set { F_DESCRICAO = value; }
        }


        public string Campo
        {
            get { return F_CAMPO; }
            set { F_CAMPO = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class sdfg
        {
            /// <summary>
            /// Texto fixo contendo "C114"
            /// </summary>
            private string F_REG = "";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            /// <summary>
            /// Código do modelo do documento fiscal, conforme a tabela indicada no item 4.1.1
            /// </summary>
            private string F_COD_MOD = "";
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value; }
            }

            /// <summary>
            /// Número de série de fabricação do ECF
            /// </summary>
            private string F_ECF_FAB = "";
            public string ECF_FAB
            {
                get { return F_ECF_FAB; }
                set { F_ECF_FAB = value; }
            }

            /// <summary>
            /// Número do caixa atribuído ao ECF
            /// </summary>
            private string F_ECF_CX = "";
            public string ECF_CX
            {
                get { return F_ECF_CX; }
                set { F_ECF_CX = value; }
            }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            private string F_NUM_DOC = "";
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value; }
            }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            private string F_DT_DOC = "";
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value; }
            }

            public string Getsdfg(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ECF_FAB */
                    if (F_ECF_FAB.Length > 21)
                    {
                        return "Erro -> Tamanho do campo de ECF_FAB incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ECF_CX */
                    if (F_ECF_CX.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de ECF_CX incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC */
                    if (F_NUM_DOC.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC */
                    if (F_NUM_DOC.Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                }

                return "|" + F_REG + "|" + F_COD_MOD + "|" + F_ECF_FAB + "|" + F_ECF_CX + "|" + F_NUM_DOC + "|" + F_DT_DOC;
            }
        }

    }
}
