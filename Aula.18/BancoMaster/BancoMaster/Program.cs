using BancoMaster;

// Cria conta poupança
ContaPoupanca conta1 = new ContaPoupanca(123456, "Pablo", 1000.00, 0.02);

// Cria conta empresa
ContaParaEmpresa conta2 = new ContaParaEmpresa(54321, "Skaf", 1200.00, 5000.00);

// Deposita valores
conta1.Deposito(200.00);
conta2.Deposito(300.00);

// Saques
conta1.SaquePoupanca(100.00); // Poupança sem taxa
conta2.Saque(150.00); // Conta empresa com taxa

// Empréstimo na conta empresa
conta2.Emprestimo(1000.00);

// Atualiza saldo da poupança com juros
conta1.AtualizacaoDeSaldo();

// Exibe dados (uso do método Dados)
conta1.Dados();
conta2.Dados();

Console.ReadLine(); // Mantém console aberto