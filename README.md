# DiskSpace

Cette application permet de surveiller l'espace disponible sur votre disque dur C: et d'enregistrer ces informations dans un fichier log. Elle est disponible en deux versions : une application console (version 1.0) et une application WPF (version 2.0).

## Version 1.0 - Application Console

### Fonctionnalités

- **Surveillance :** L'application surveille l'espace disponible sur le disque dur C: et affiche les informations à intervalles réguliers.
- **Personnalisation :** L'utilisateur peut définir l'intervalle de temps (en secondes) entre chaque vérification. Par défaut, cet intervalle est de 10 secondes.
- **Log :** Toutes les informations sur l'espace disque sont enregistrées dans un fichier log.

### Fonctionnement

1. **Lancement du programme :** Exécutez l'application depuis la ligne de commande. Vous pouvez spécifier l'intervalle de temps en secondes comme argument. Exemple : `DiskSpace.exe 15` pour un intervalle de 15 secondes.

2. **Consultation des logs :** Les informations sont enregistrées dans un fichier log.

### Diagrammes
1. Diagramme de classe :
<img width="3168" alt="DiskSpace CLASS V1 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/0193fce4-ef37-44e1-9e50-2d5eaface817">

2. Diagramme cas d'utilisation :

3. Diagramme séquence :
<img width="4574" alt="DiskSpace - Sequence v1 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/ed91e7cb-82bc-43fb-aa18-f478b89fba93">

## Version 2.0 - Application WPF

### Fonctionnalités

- **Interface :** Contrairement à la version console, cette version offre une interface graphique permettant une interaction plus intuitive avec l'application.
- **Surveillance :** L'application continue de surveiller l'espace disque et d'enregistrer les données sans interruption.
- **Personnalisation :** L'utilisateur peut définir l'intervalle de temps (en secondes) entre chaque vérification. Par défaut, cet intervalle est de 10 secondes.
- **Log :** L'application WPF permet de visualiser le fichier log directement depuis l'interface, sans arrêter le processus d'enregistrement.
  /!\ Veuillez à ne pas écrire dans le fichier log, sinon l'application ne pourra pas écrire dedans /!\

### Fonctionnement

1. **Lancement de l'application :** Double-cliquez sur l'icône de l'application pour la lancer.
2. **Configuration de l'intervalle :** Utilisez l'interface graphique pour ajuster l'intervalle de temps entre chaque vérification de l'espace disque.
3. **Visualisation du log :** Accédez à la section dédiée dans l'application pour lire le fichier log en temps réel, tout en continuant la surveillance de l'espace disque.

### Diagrammes
1. Diagramme de classe :
<img width="3175" alt="DiskSpace Classe v2 0" src="https://github.com/Roooomain/Rattrapage-DiskSpace/assets/119046014/8ac97d02-72e8-4c59-b4ec-02063e037839">

2. Diagramme cas d'utilisation :

3. Diagramme séquence :
