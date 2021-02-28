**Le serveur web repond au requete du type:**\
http://127.0.0.1:8080/method/toto/miaou/dora?param1=salut&param2=le&param3=monde&param4=!!!!

**Pour utiliser le cgi il faut mettre cgi en debut de chemin:**\
http://127.0.0.1:8080/cgi/toto/miaou/dora?param1=salut&param2=le&param3=monde&param4=!!!!

**Pour utiliser la reflection il faut mettre le nom de la methode a utiliser au debut de chemin:**\
http://127.0.0.1:8080/reflection/toto/miaou/dora?param1=salut&param2=le&param3=monde&param4=!!!!
http://127.0.0.1:8080/reflectionSecond/toto/miaou/dora?param1=salut&param2=le&param3=monde&param4=!!!!
http://127.0.0.1:8080/hidden/toto/miaou/dora?param1=salut&param2=le&param3=monde&param4=!!!!


**Les autres base de chemin utiliseront la method standard (Apres une Exception attrape dans un try catch) :**\
http://127.0.0.1:8080/d/toto/miaou/dora?param1=salut&param2=le&param3=monde&param4=!!!!
http://127.0.0.1:8080/yay/toto/miaou/dora?param1=salut&param2=le&param3=monde&param4=!!!!
