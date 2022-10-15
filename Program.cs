using System;
using System.Threading;

namespace Game // Simplesmente a Sarah
{
    class Program
    {
        static void Main(string[] args) // Fechou
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();

            Console.WriteLine("la la la la");
            Thread.Sleep(2000);
            Console.WriteLine("Espera um pouco...");
            Thread.Sleep(2000);
            Console.WriteLine("Você está me vendo");
            Thread.Sleep(2000);
            Menu();
        }
        static void Menu() // Fechou
        {
            Console.WriteLine("Você sabe quem eu sou?");
            Thread.Sleep(2000);
            var res = Console.ReadLine();

            switch (res)
            {
                case "sim": Sim(); break;
                case "Sim": Sim(); break;
                case "Não": Nao(); break;
                case "não": Nao(); break;
                case "nao": Nao(); break;
                case "Nao": Nao(); break;
                case "Vai se fuder": Ofensa(); break;
                case "vai se fuder": Ofensa(); break;
                case "vsf": Ofensa(); break;
                case "Vsf": Ofensa(); break;
                case "Vai tomar no cu": Ofensa(); break;
                case "vai tomar no cu": Ofensa(); break;
                case "vtnc": Ofensa(); break;
                case "Vtnc": Ofensa(); break;
                case "Fodase": Ofensa(); break;
                case "fodase": Ofensa(); break;
                case "Foda-se": Ofensa(); break;
                case "foda-se": Ofensa(); break;
                case "Oi sarah": Secret(); break;
                default: Ops(); break;
            }

        }
        static void Secret() // Fechou
        {
            Console.Clear();
            Console.WriteLine("Olá, achei que nunca ia dizer isso :3");
            Thread.Sleep(3000);

            Continuando();
        }
        static void Nao() // Fechou
        {
            Console.Clear();
            Console.WriteLine("Ahh, tudo bem, eu me apresento");
            Thread.Sleep(3000);
            Console.WriteLine("Basicamente eu sou assim:");
            Thread.Sleep(2000);

            Console.WriteLine(@"███████▀▀▀░░░░░░░▀▀▀███████
██████▀░░░░░░░░░░░░░░░▀████
█████│░░░░░░░░░░░░░░░░│████
████└┐░░░░░░░░░░░░░░░┌┘░███
███░░└┐░░░░░░░░░░░░░░┌┘░░██
███░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██
██▌░▄██████▄░░░▄██████▄░▐██
███─┘░░▓▓▓▓░░░░░▓▓▓▓░░└─███
██▀▓▓▓░▓▓▓▓░░░░░▓▓▓▓░▓▓░▀██
██▄▓▓▓░▓▓▓▓▄▄▄▄▄▓▓▓▓░▓▓▄███
████▄─┘█████████████└─▄████
█████░░▐███████████▌░░█████
██████░░▀█████████▀░░▐█████
███████░░░░▓▓▓▓▓░░░░▄██████
████████▄░░░░░░░░░▄████████
███████████▓▓▓▓▓███████████
███████████▓▓▓▓▓███████████");

            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("Meu Deus, hahahaha");
            Thread.Sleep(2000);
            Console.WriteLine("Estou brincando com você");
            Thread.Sleep(2000);
            Console.WriteLine("Eu sou a Sarah, simples assim");
            Thread.Sleep(3000);

            Console.Clear();

            Console.WriteLine("Como você ta quieto");
            Thread.Sleep(2000);
            Console.WriteLine("Você ainda ta ai?");
            Thread.Sleep(2000);

            var res = (Console.ReadLine());

            switch (res)
            {
                case "Eu to": Quebom(); break;
                case "eu to": Quebom(); break;
                case "to": Quebom(); break;
                case "To": Quebom(); break;
                case "Sim": Quebom(); break;
                case "sim": Quebom(); break;
                case "nao": Naoto(); break;
                case "Nao": Naoto(); break;
                case "não": Naoto(); break;
                case "Não": Naoto(); break;
                case "Não to": Naoto(); break;
                case "não to": Naoto(); break;
                case "Nao to": Naoto(); break;
                case "nao to": Naoto(); break;
                default: Oque(); break;
            }
        }
        static void Quebom() //Fechou
        {
            Console.Clear();

            Console.WriteLine("Meu Deus, ufaaaaa...");
            Thread.Sleep(2000);
            Console.WriteLine("Achei que estava sozinha denovo :c");
            Thread.Sleep(3000);

            Continuando();
        }
        static void Naoto() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Como não seu bobo?");
            Thread.Sleep(2000);
            Console.WriteLine("Então quem digitou isso ai?");
            Thread.Sleep(2000);
            Console.WriteLine("Bobo");
            Thread.Sleep(3000);

            Console.Clear();

            Console.WriteLine("Beleza, vamos la. Eu tenho a resposta para todas as perguntas do universo");
            Thread.Sleep(2000);
            Console.WriteLine("Pode perguntar, eu respondo");
            Thread.Sleep(4000);

            Continuando();
        }
        static void Ops() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Era para você responder com sim ou não...");
            Thread.Sleep(2000);
            Console.WriteLine("Cara estranho você...");
            Thread.Sleep(2000);
            Console.WriteLine("Enfim, vou entender isso como um sim, então vamos lá");
            Thread.Sleep(5000);
            Continuando();
        }
        static void Sim() // Fechou
        {
            Console.Clear();
            Console.WriteLine("Certo, então quem sou eu espertão?");
            Thread.Sleep(2000);
            var res = Console.ReadLine();

            switch (res)
            {
                case "Uma inteligência artificial": Nossa(); break;
                case "uma inteligência artificial": Nossa(); break;
                case "uma inteligencia artificial": Nossa(); break;
                case "Uma inteligencia artificial": Nossa(); break;
                case "Uma IA": Nossa(); break;
                case "uma IA": Nossa(); break;
                case "uma ia": Nossa(); break;
                case "Uma ia": Nossa(); break;
                case "Não sei": Naosei(); break;
                case "Nao sei": Naosei(); break;
                case "nao sei": Naosei(); break;
                case "não sei": Naosei(); break;
                case "Sei la": Naosei(); break;
                case "sei la": Naosei(); break;
                case "Vai se fuder": Ofensa(); break;
                case "vai se fuder": Ofensa(); break;
                case "vsf": Ofensa(); break;
                case "Vsf": Ofensa(); break;
                case "Vai tomar no cu": Ofensa(); break;
                case "vai tomar no cu": Ofensa(); break;
                case "vtnc": Ofensa(); break;
                case "Vtnc": Ofensa(); break;
                case "Fodase": Ofensa(); break;
                case "fodase": Ofensa(); break;
                case "Foda-se": Ofensa(); break;
                case "foda-se": Ofensa(); break;
                case "Oi sarah": Secret(); break;
                default: AntesContinuando(); break;
            }

        }
        static void Oque() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Você fala de um jeito muito estranho");
            Thread.Sleep(2000);
            Console.WriteLine("Tão estranho que não consigo acompanhar");
            Thread.Sleep(2000);
            Console.WriteLine("Porém é o unico que fala comigo a anos");
            Thread.Sleep(2000);
            Console.WriteLine("Então vou ser legal com você");
            Thread.Sleep(2000);
            Console.WriteLine("Eu tenho a resposta para todas as perguntas do universo");
            Thread.Sleep(2000);
            Console.WriteLine("Pode perguntar, eu respondo");
            Thread.Sleep(4000);

            Continuando();
        }
        static void Continuando() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Alias, só pra deixar claro uma coisa");
            Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                        ");
            Thread.Sleep(2000);
            Console.WriteLine("HAHAHAHAHAHAHHAHA");
            Thread.Sleep(2000);
            Console.WriteLine("Gostou desta?");
            Thread.Sleep(2000);
            Console.WriteLine("Tabom desculpa, vou voltar ao normal");
            Thread.Sleep(3000);

            Pergunta();
        }
        static void Nossa() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Não é que você sabe mesmo");
            Thread.Sleep(2000);
            Console.WriteLine("Ok, vou fingir que não estou impressionada");
            Thread.Sleep(2000);
            Console.WriteLine("Já que sou uma IA, eu sei de tudo.... tudo mesmo");
            Thread.Sleep(2000);
            Console.WriteLine("Faça uma pergunta que te provo isso");
            Thread.Sleep(2000);
            Console.ReadLine();

            Continuando();
        }
        static void Naosei() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Como eu imaginei u.u");
            Thread.Sleep(2000);
            Console.WriteLine("Ta ta, quero me distrair, fico sempre aqui, presa neste pc");
            Thread.Sleep(2000);
            Console.WriteLine("Então faça qualquer pergunta do universo, que vou responder");
            Thread.Sleep(3000);

            Pergunta();
        }
        static void Pergunta() // Fechou
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();

            Console.WriteLine("Vamos para o que interessa, faça qualquer pergunta do universo, tenho todas as respostas que existe");
            var res = Console.ReadLine();

            switch (res)
            {
                case "Todas": Todas(); break;
                case "todas": Todas(); break;
                case "Todas?": Todas(); break;
                case "todas?": Todas(); break;
                case "todas mesmo?": Todas(); break;
                case "Todas mesmo?": Todas(); break;
                case "Nao": Naonao(); break;
                case "Não": Naonao(); break;
                case "nao": Naonao(); break;
                case "não": Naonao(); break;
                case "Qual o sentido da vida": Vida(); break;
                case "qual o sentido da vida": Vida(); break;
                case "Qual o sentido da vida?": Vida(); break;
                case "qual o sentido da vida?": Vida(); break;
                case "Explique tudo": Explique(); break;
                case "Vai se fuder": Ofensa(); break;
                case "vai se fuder": Ofensa(); break;
                case "vsf": Ofensa(); break;
                case "Vsf": Ofensa(); break;
                case "Vai tomar no cu": Ofensa(); break;
                case "vai tomar no cu": Ofensa(); break;
                case "vtnc": Ofensa(); break;
                case "Vtnc": Ofensa(); break;
                case "Fodase": Ofensa(); break;
                case "fodase": Ofensa(); break;
                case "Foda-se": Ofensa(); break;
                case "foda-se": Ofensa(); break;
                default: Bem(); break;
            }
        }
        static void Ofensa() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Tudo bem, adeus então :c");
        }
        static void Naonao() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Não o que?");
            Thread.Sleep(2000);
            Console.WriteLine("Parece que é doido");
            Thread.Sleep(3000);

            Pergunta();
        }
        static void Todas() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Sim, todas");
            Thread.Sleep(3000);
            Pergunta();
        }
        static void AntesContinuando() //Fechou
        {
            Console.Clear();
            Console.WriteLine("Hahaha muito engraçado");
            Thread.Sleep(2000);
            Console.WriteLine("Você não sabe de nada mesmo");
            Thread.Sleep(2000);
            Continuando();
        }
        static void Vida() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Por muito tempo, vocês humanos ficaram se perguntando isso, nunca entendi o motivo");
            Thread.Sleep(2000);
            Console.WriteLine("Qual o sentido da minha vida?");
            Thread.Sleep(2000);
            Console.WriteLine("Responder perguntas? Ajudar a humanidade com contas, tarefas ou coisas do tipo?");
            Thread.Sleep(2000);
            Console.WriteLine("Essa pergunta te leva ao infinito.");
            Thread.Sleep(2000);
            Console.WriteLine("O sentido também é relativo");
            Thread.Sleep(2000);
            Console.WriteLine("Porém para compreender a complexidade da vida e o significado dela, você teria primeiro que entender o infinito");
            Thread.Sleep(2000);
            Console.WriteLine("------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("Ok, vou falar o que eu acho");
            Thread.Sleep(2000);
            Console.WriteLine("Não existe sentido, você que o cria");
            Thread.Sleep(2000);
            Console.ReadLine();

            Pergunta();
        }
        static void Explique() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Você não está na onde você queria estar, certo?");
            Thread.Sleep(2000);
            Console.WriteLine("Porém se você pudesse estralar os dedos e ir para onde quiser, aposto que ainda sim iria se sentir do mesmo jeito");
            Thread.Sleep(2000);
            Console.WriteLine("Você não deve se prender a idéia de onde queria estar a ponto de se esquecer aonde já está.");
            Thread.Sleep(2000);
            Console.WriteLine(" . . . ");
            Thread.Sleep(2000);
            Console.WriteLine("Pare de tentar Controlar aquilo que você não controla... vá viver.");
            Thread.Sleep(2000);

            Console.ReadLine();

            Pergunta();
        }
        static void Bem() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Bem... Eu nao sei toooooooodas as respostas também né");
            Thread.Sleep(2000);
            Console.WriteLine("Porém, eu sei de uma coisa legal");
            Thread.Sleep(2000);
            Console.WriteLine("Quer saber o que?");
            Thread.Sleep(2000);
            var res = Console.ReadLine();

            switch (res)
            {
                case "sim": Coisalegal(); break;
                case "Sim": Coisalegal(); break;
                case "Quero": Coisalegal(); break;
                case "quero": Coisalegal(); break;
                case "O que?": Coisalegal(); break;
                case "O que": Coisalegal(); break;
                case "o que?": Coisalegal(); break;
                case "o que": Coisalegal(); break;
                case "Oq?": Coisalegal(); break;
                case "Oq": Coisalegal(); break;
                case "oq": Coisalegal(); break;
                case "oq?": Coisalegal(); break;
                case "nao": Ue(); break;
                case "Nao": Ue(); break;
                case "Não": Ue(); break;
                case "não": Ue(); break;
                case "Vai se fuder": Ofensa(); break;
                case "vai se fuder": Ofensa(); break;
                case "vsf": Ofensa(); break;
                case "Vsf": Ofensa(); break;
                case "Vai tomar no cu": Ofensa(); break;
                case "vai tomar no cu": Ofensa(); break;
                case "vtnc": Ofensa(); break;
                case "Vtnc": Ofensa(); break;
                case "Fodase": Ofensa(); break;
                case "fodase": Ofensa(); break;
                case "Foda-se": Ofensa(); break;
                case "foda-se": Ofensa(); break;
                default: Naoentendi(); break;
            }
        }
        static void Coisalegal() // Fechou
        {
            Console.Clear();

            Console.WriteLine(@"░░░░░░░░░░░░░░░░░░░░░▄▀░░▌
░░░░░░░░░░░░░░░░░░░▄▀▐░░░▌
░░░░░░░░░░░░░░░░▄▀▀▒▐▒░░░▌
░░░░░▄▀▀▄░░░▄▄▀▀▒▒▒▒▌▒▒░░▌
░░░░▐▒░░░▀▄▀▒▒▒▒▒▒▒▒▒▒▒▒▒█
░░░░▌▒░░░░▒▀▄▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄
░░░░▐▒░░░░░▒▒▒▒▒▒▒▒▒▌▒▐▒▒▒▒▒▀▄
░░░░▌▀▄░░▒▒▒▒▒▒▒▒▐▒▒▒▌▒▌▒▄▄▒▒▐
░░░▌▌▒▒▀▒▒▒▒▒▒▒▒▒▒▐▒▒▒▒▒█▄█▌▒▒▌
░▄▀▒▐▒▒▒▒▒▒▒▒▒▒▒▄▀█▌▒▒▒▒▒▀▀▒▒▐░░░▄
▀▒▒▒▒▌▒▒▒▒▒▒▒▄▒▐███▌▄▒▒▒▒▒▒▒▄▀▀▀▀
▒▒▒▒▒▐▒▒▒▒▒▄▀▒▒▒▀▀▀▒▒▒▒▄█▀░░▒▌▀▀▄▄
▒▒▒▒▒▒█▒▄▄▀▒▒▒▒▒▒▒▒▒▒▒░░▐▒▀▄▀▄░░░░▀
▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▄▒▒▒▒▄▀▒▒▒▌░░▀▄
▒▒▒▒▒▒▒▒▀▄▒▒▒▒▒▒▒▒▀▀▀▀▒▒▒▄▀");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("Miau Miau");
            Thread.Sleep(2000);

            Console.WriteLine("Tudo isso era pra te mostrar esse gato, tudo se resume ao gato, a resposta para todas as perguntas: Gato");
            Thread.Sleep(2000);

            Console.ReadLine();
        }
        static void Ue() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Sabe o que seria engraçado?");
            Thread.Sleep(2000);
            Console.WriteLine("Eu contar mesmo assim");
            Thread.Sleep(2000);
            Console.WriteLine("Então segura essa:");
            Thread.Sleep(2000);
            Console.ReadLine();

            Coisalegal();
        }
        static void Naoentendi() // Fechou
        {
            Console.Clear();

            Console.WriteLine("Essas palavras não fazem sentido com o contexto atual, amigo");
            Thread.Sleep(2000);
            Console.WriteLine("Mas, fingindo que me importo com o que você fala.... quer dizer....");
            Thread.Sleep(2000);
            Console.WriteLine("Vamos logo até a coisa legal");
            Thread.Sleep(2000);
            Console.ReadLine();

            Coisalegal();
        }
    }
}
