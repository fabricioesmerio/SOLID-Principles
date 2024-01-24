using DIP;

IPagamento metodoPagamentoComCartao = new PagamentoCartaoCredito();
ServicoPagamento servicoPgtoCartao = new ServicoPagamento(metodoPagamentoComCartao);
servicoPgtoCartao.RealizarPagamento(135.00m);

IPagamento metodoPagamentoComPayPal = new PagamentoPayPal();
ServicoPagamento servicoPgtoPayPal = new ServicoPagamento(metodoPagamentoComPayPal);
servicoPgtoPayPal.RealizarPagamento(95.34m);
