using System.Windows.Forms;

namespace ConroleAcesso.Extensions
{
    public static class GridViewExtension
    {

        public static int GetCountRowsChecked(this DataGridViewRowCollection linhas, int indexColCheck)
        {
            int qtde = 0;

            foreach(DataGridViewRow linha in linhas)
            {
                var cell = linha.Cells[indexColCheck] as DataGridViewCheckBoxCell;
                if (cell.Value != null && (bool)cell.Value)
                    ++qtde;
            }

            return qtde;
        }

        public static int GetFirstIndexChecked(this DataGridViewRowCollection linhas, int indexColCheck)
        {
            int index = -1;

            foreach (DataGridViewRow linha in linhas)
            {
                var cell = linha.Cells[indexColCheck] as DataGridViewCheckBoxCell;
                ++index;

                if (cell.Value != null && (bool)cell.Value)
                    return index;
            }

            return -1;
        }
    }
}
