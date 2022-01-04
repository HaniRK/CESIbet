# CESIbet
Mini-jeu entre amis

Notice technique : 

Installation : 
Cesibet\bin\Debug\netcoreapp3.1\Cesibet.exe

Fonctionnement :
Le joueur qui lance le jeu fait office de serveur pour les autres et peut paramétrer le nombre de joueurs qui peuvent entrer dans la partie ainsi que le nombre de tours de jeux. La partie ne peut démarrer que lorsque tous les joueurs nécessaires sont présents. Chaque joueur dispose de sa propre fenêtre de fenêtre.
A chaque tour de jeu, les joueurs reçoivent sur leur fenêtre de jeu la même question à laquelle ils doivent répondre par oui ou par non, puis doivent estimer le nombre de oui total des joueurs avant de valider ces réponses. Lorsque tous les joueurs ont donné leurs réponses, le nombre de oui est affiché sur chaque fenêtre et les joueurs ayant bien estimé ce nombre gagnent 2 points. Si personne n’a bien estimé ce nombre, les joueurs les plus proches de ce nombre par score inférieur à ce nombre uniquement gagnent 1 point.
Lorsque le nombre de tours défini par le joueur qui a lancé la partie est terminé, le gagnant est le joueur (ou les joueurs) ayant le plus de points.
Le jeu s’arrête et compte le nombre de points au cas où un joueur n’interagit plus.

Design Patterns : 
MVVM pour séparer la logique du programme et les contrôles de l’interface utilisateur UI.
Abstract factory pour encapsuler des familles d'objets liés qui ont un thème commun sans spécifier leurs classes concrètes.
Singleton afin de restreindre l'instanciation d'une classe à un seul objet (ou bien à quelques objets seulement).
Strategy afin de permuter dynamiquement les algorithmes utilisés. Il permet de fournir le moyen de définir une famille d'algorithmes, encapsuler chacun d'eux en tant qu'objet, et les rendre interchangeables.

Mécanisme de synchronisation :
Sockets. Ils permettent une communication point-to-point et bidirectionnelle entre deux processus. ils sont très polyvalents et constituent un élément de base de la communication interprocessus et intersystème. 





