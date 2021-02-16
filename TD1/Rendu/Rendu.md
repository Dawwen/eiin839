# Question 1 :Pourquoi devons-nous utiliser ici le port 8080 ?

Les port plus petit que 1024 sont reserve. on devrait utiliser le 80 liee au http

# Question 2 :Quel est le résultat obtenu ?

``` 
dawen@DESKTOP-8SKPRHI:~$ telnet www.tigli.fr 80
Trying 134.59.134.195...
Connected to www.tigli.fr.
Escape character is '^]'.
GET /
<html><body><h1>Welcome to Nyx</h1></body></html>
Connection closed by foreign host.
```

# Question 3:Combien de requêtes HTTP sont déclenchéespour récupérer l’intégralité de la page ?
Beaucoup de requetes.
```
voir image rendu1
```

# Question 4:Mesurez et comparez les durées de récupération de la page www.google.comavec ou sans utilisation du cache local. Quel est le % de gain de temps ? de bande passante ?

Sans cache  total 5.46s
Avec cache 550ms total 5.87s

# Question 5