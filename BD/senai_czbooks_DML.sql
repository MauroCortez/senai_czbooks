USE senai_czbooks

INSERT INTO TipoUsuario				(TipoUsuario)
VALUES								('Administrador')
									,('Autor')
									,('Cliente')
;

INSERT INTO Usuario					(Usuario, Senha, idTipoUsuario)
VALUES								('Adm', 'adm123', 1)
									,('Mauro', 'mauro123', 3)
									,('Daniel', 'daniel123', 3)
									,('Kaiky', 'kaiky123', 3)
									,('Douglas Adams', 'douglas123', 2)
									,('Reiji Miyajima', 'reiji123', 2)
									,('J.K. Rowling ', 'rowling', 2)
									,('Higor Vinicius Nogueira Jorge', 'higor123', 2)
									,('Lewis Carroll', 'lewis123', 2)
;

INSERT INTO Empresa					(NomeFantasia)
VALUES								('CZBooks')
;

INSERT INTO Livro					(Titulo, Sinopse, Categoria, idUsuario, DataPublicacao, Preco, idEmpresa)
VALUES								('O guia definitivo do mochileiro das gal�xias', 'O Restaurante no Fim do Universo � Arthur Dent e seus companheiros viajam pela Gal�xia em uma busca desesperada por algum lugar para comer. 
Depois de fazer a refei��o mais estranha de suas vidas, eles seguem pelo espa�o e acabam descobrindo a quest�o fundamental sobre a Vida, 
o Universo e Tudo Mais.', 'Ficcao Cientifica', 5, '2020-04-20', 'R$60,00', 1)
									,('Namorada de Aluguel Volume 1', 'Kazuya Kinoshita � um estudante universit�rio in�til que decide utilizar um aplicativo de relacionamentos depois de ter levado um fora de sua namorada. Assim, 
o rapaz conhece uma bela garota chamada Chizuru Mizuhara e a vida dos dois come�a a mudar a partir da�.', 'Romance', 6, '2018-12-28', 'R$27,64', 1)
									,('Harry Potter e a ordem da f�nix', 'Harry Potter est� em seu quinto ano em Hogwarts e acaba ouvindo que muitos n�o sabem a verdade sobre seu encontro com Lord Voldemort. 
O Ministro de M�gica, Cornelius Fudge, indica Dolores Umbridge para ser a nova professora de Defesa Contra as Artes das Trevas, por acreditar que Dumbledore planeja tomar seu lugar. 
Por�m, os m�todos que ela usa s�o totalmente inapropriados. Harry, ent�o, se re�ne com um grupo de alunos para defender sua escola.', 'Fantasia', 7, '2017-08-19', 'R$48,50', 1)
									,('Investiga��o Criminal Tecnol�gica', 'O volume 1 aborda alguns procedimentos pr�ticos de investiga��o criminal tecnol�gica, incluindo aspectos essenciais sobre infiltra��o virtual de agentes na rede mundial de computadores, informa��es sobre Uber, WhatsApp, Facebook, Twitter, Netflix, PayPal, Ebay, OLX, bem como ferramentas para investiga��o em fontes abertas e modelos de requisi��o, auto de materializa��o de evid�ncias eletr�nicas, representa��o de afastamento de sigilo eletr�nico e relat�rio de investiga��o.

Para tornar a obra mais did�tica foram elaborados diagramas, sintetizando a demonstra��o dos procedimentos apontados nos modelos de documentos da Pol�cia Judici�ria.', 'Policial', 8, '2018-12-28', 'R$42,56', 1)
									,('Alice Atrav�s do Espelho', 'Alice retorna ap�s uma longa viagem pelo mundo, e reencontra a m�e. 
No casar�o de uma grande festa, percebe a presen�a de um espelho m�gico. A jovem atravessa o objeto e retorna ao Pa�s das Maravilhas, onde descobre que o Chapeleiro Maluco e sua fam�lia correm risco de morte. 
Para salvar o amigo, Alice deve conversar com o Tempo para voltar �s v�speras de um evento traum�tico e mudar seus destinos cru�is.', 'Aventura', 9, '2021-04-07', 'R$42,90', 1)
;