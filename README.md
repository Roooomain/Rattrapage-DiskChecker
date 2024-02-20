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

## Version 2.0 - Application WPF

### Fonctionnalités

- **Interface** : Contrairement à la version 1.0, cette version offre une interface utilisateur graphique pour une interaction plus intuitive.
- **Personnalisation** : L'intervalle de temps entre chaque vérification de l'espace disque peut être ajusté via l'interface utilisateur.
- **Log** : L'utilisateur peut consulter le fichier log directement depuis l'application sans interrompre le processus.

### Fonctionnement

1. **Lancement de l'application :** Double-cliquez sur l'icône de l'application pour la lancer. Aucun argument de ligne de commande n'est nécessaire pour cette version.

2. **Paramétres :** Dans l'interface, vous pouvez régler l'intervalle entre chaque surveillance. La valeur par défaut est de 10 secondes.

3. **Consultation des Logs :** Un onglet de l'interface permet de consulter le fichier log tout en continuant la surveillance.

<img width="532" alt="DiskChecker - Warning" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/37d3be2d-8d58-431b-b5b8-cadc663f5fa8">

### Diagrammes
1. Diagramme de classe :
<img width="3181" alt="DiskChecker - Classe v2 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/dcb1c4e4-a91a-4f6d-8522-ec4260debae2">

2. Diagramme cas d'utilisation :
<img width="4240" alt="DiskChecker - UseCase - v2 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/78b01340-a224-46a2-93de-1aaad493c81b">

3. Diagramme séquence :
<img width="6048" alt="DiskChecker - Sequence v2 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/36f4aa00-05e7-4117-896f-fa52f83f084f">
