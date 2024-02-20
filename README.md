# DiskChecker

Cette application permet de surveiller l'espace disponible sur votre disque dur C: et d'enregistrer ces informations dans un fichier log. Elle est disponible en deux versions : une application console (version 1.0) et une application WPF (version 2.0).

## Version 1.0 - Application Console

### Fonctionnalités

- **Surveillance :** L'application surveille l'espace disponible sur le disque dur C: et affiche les informations à intervalles réguliers.
- **Personnalisation :** L'utilisateur peut définir l'intervalle de temps (en secondes) entre chaque vérification. Par défaut, cet intervalle est de 10 secondes.
- **Log :** Toutes les informations sur l'espace disque sont enregistrées dans un fichier log.

### Fonctionnement

1. **Lancement du programme :** Exécutez l'application depuis la ligne de commande. Vous pouvez spécifier l'intervalle de temps en secondes comme argument. Exemple : `DiskCheckerConsole.exe 15` pour un intervalle de 15 secondes.

2. **Consultation des logs :** Les informations sont enregistrées dans un fichier log.

### Diagrammes
1. Diagramme de classe :
<img width="3168" alt="DiskChecker - Classe v1 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/79b81e33-fa54-4498-a5ed-c148972d58f2">

2. Diagramme cas d'utilisation :
<img width="4240" alt="DiskChecker - UseCase - v1 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/0d34f507-42a3-4a5a-9ae4-86f9bed1c72a">

3. Diagramme séquence :
<img width="4574" alt="DiskChecker - Sequence v1 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/547687fa-4992-4b10-9014-82d06c5d8394">
