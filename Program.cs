using Sistema_e_abstraindo_um_celular.Models;

Nokia cel1 = new Nokia("1191434352", "Modelo 1", "1111111", 64);
Iphone cel2 = new Iphone("11978754523", "modelo 2", "2222222", 32);

cel1.Ligar();
cel1.ReceberLigação();

cel2.Ligar();
cel2.ReceberLigação();

cel1.InstalarAplicativo("Whatsapp");
cel2.InstalarAplicativo("Telegram");