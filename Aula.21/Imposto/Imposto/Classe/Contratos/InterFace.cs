using System; // Importa funcionalidades básicas
using System.Collections.Generic; // Lista
using System.Text; // Manipulação de texto

namespace Imposto.Classe.Contratos // Namespace informado
{
    internal interface InterFace // Interface para cálculo de imposto
    {
        double CalcularImposto(); // Método obrigatório
    }
}