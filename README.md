# DiskSpace

Cette application permet de surveiller l'espace disponible sur votre disque dur C: et d'enregistrer ces informations dans un fichier log. Elle est disponible en deux versions : une application console (version 1.0) et une application WPF (version 2.0).

## Version 1.0 - Application Console

### Fonctionnalités

- **Surveillance de l'espace disque :** L'application surveille l'espace disponible sur le disque dur C: et affiche les informations à intervalles réguliers.
- **Personnalisation de l'intervalle :** L'utilisateur peut définir l'intervalle de temps (en secondes) entre chaque vérification. Par défaut, cet intervalle est de 10 secondes.
- **Enregistrement dans un fichier log :** Toutes les informations sur l'espace disque sont enregistrées dans un fichier log.

### Comment utiliser

1. **Lancement de l'application :** Exécutez l'application depuis la ligne de commande. Vous pouvez spécifier l'intervalle de temps en secondes comme argument. Exemple : `DiskSpace.exe 15` pour un intervalle de 15 secondes.
2. **Consultation des logs :** Les informations sont enregistrées dans un fichier log.

## Version 2.0 - Application WPF

### Fonctionnalités

- **Interface utilisateur graphique :** Contrairement à la version console, cette version offre une interface graphique permettant une interaction plus intuitive avec l'application.
- **Surveillance continue :** L'application continue de surveiller l'espace disque et d'enregistrer les données sans interruption.
- **Visualisation du fichier log :** L'application WPF permet de visualiser le fichier log directement depuis l'interface, sans arrêter le processus d'enregistrement.

### Comment utiliser

1. **Lancement de l'application :** Double-cliquez sur l'icône de l'application pour la lancer.
2. **Configuration de l'intervalle :** Utilisez l'interface graphique pour ajuster l'intervalle de temps entre chaque vérification de l'espace disque.
3. **Visualisation du log :** Accédez à la section dédiée dans l'application pour lire le fichier log en temps réel, tout en continuant la surveillance de l'espace disque.
