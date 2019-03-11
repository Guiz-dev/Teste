﻿using System;
using System.Globalization;


namespace SalarioFuncionario {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public override string ToString() {
            return Nome +", R$: " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += SalarioBruto / (porcentagem/100);
        }
    }
}
