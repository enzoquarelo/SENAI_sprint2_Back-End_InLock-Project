USE  inlock_games_manha;

INSERT INTO Estudio(Nome)
VALUES ('Blizzard'),('Rockstar Studios'),('Hoyoverse');

INSERT INTO Jogo(IdEstudio,Nome,Descricao,DataLancamento,Valor)
VALUES (1,'Overwatch 2','É um jogo com diversos personagens e foi uma inovação a franquia Overwatch com muitas novidade!','2022-10-04','$0')
	  ,(2,'grand theft auto V','Jogo eletrônico de ação-aventura que pode ser jogado a partir de diversas perspectivas.','2013-09-19','200');

INSERT INTO TiposUsuario(Titulo)
VALUES ('Comum'),('Administrador');

INSERT INTO Usuario(IdTipoUsuario,Email,Senha)
VALUES (1,'cliente@cliente.com','cliente')
      ,(2,'admin@admin.com','admin');

