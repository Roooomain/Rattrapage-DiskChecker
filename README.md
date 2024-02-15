# DiskSpace

Cette application permet de surveiller l'espace disponible sur votre disque dur C: et d'enregistrer ces informations dans un fichier log. Elle est disponible en deux versions : une application console (version 1.0) et une application WPF (version 2.0).

## Version 1.0 - Application Console

### Fonctionnalit�s

- **Surveillance de l'espace disque :** L'application surveille l'espace disponible sur le disque dur C: et affiche les informations � intervalles r�guliers.
- **Personnalisation de l'intervalle :** L'utilisateur peut d�finir l'intervalle de temps (en secondes) entre chaque v�rification. Par d�faut, cet intervalle est de 10 secondes.
- **Enregistrement dans un fichier log :** Toutes les informations sur l'espace disque sont enregistr�es dans un fichier log.

### Comment utiliser

1. **Lancement de l'application :** Ex�cutez l'application depuis la ligne de commande. Vous pouvez sp�cifier l'intervalle de temps en secondes comme argument. Exemple : `DiskSpace.exe 15` pour un intervalle de 15 secondes.
2. **Consultation des logs :** Les informations sont enregistr�es dans un fichier log dans le r�pertoire de l'application.

## Version 2.0 - Application WPF

### Fonctionnalit�s

- **Interface utilisateur graphique :** Contrairement � la version console, cette version offre une interface graphique permettant une interaction plus intuitive avec l'application.
- **Surveillance continue :** L'application continue de surveiller l'espace disque et d'enregistrer les donn�es sans interruption.
- **Visualisation du fichier log :** L'application WPF permet de visualiser le fichier log directement depuis l'interface, sans arr�ter le processus d'enregistrement.

### Comment utiliser

1. **Lancement de l'application :** Double-cliquez sur l'ic�ne de l'application pour la lancer.
2. **Configuration de l'intervalle :** Utilisez l'interface graphique pour ajuster l'intervalle de temps entre chaque v�rification de l'espace disque.
3. **Visualisation du log :** Acc�dez � la section d�di�e dans l'application pour lire le fichier log en temps r�el, tout en continuant la surveillance de l'espace disque.
