# Unity2020.3.18f1-README-Template

### Projektbeschreibung: 
Einführung in / Zusammenfassung des Projektes. 

### Entwicklungsplattform: 
(Betriebsystem, Unity Version, Visual Studio Version, verwendete SDKs)

link:
https://3ahmns2122mtin.github.io/03lmadlen-UE02-shootingIsland/

### Zielplattform: 
WebGL Referenzauflösung (960x600) 

### Visuelle Einblicke in das Projekt: 
Screenshots (Konzept, Spielabschnitte), Video (< 100MB, < 3 min)
#### Planung
![WhatsApp Image 2021-10-07 at 10 32 56](https://user-images.githubusercontent.com/62291189/136520371-76778fbc-4550-4752-ac2a-a6041a7d72a0.jpeg)
#### Zwischenstand 8.Okt.2021
![WhatsApp Image 2021-10-08 at 10 15 32](https://user-images.githubusercontent.com/62291189/136522448-4ada02c6-4540-4080-946b-1461fb190dbe.jpeg)
<img width="1399" alt="Bildschirmfoto 2021-10-08 um 10 18 33" src="https://user-images.githubusercontent.com/62291189/136522675-0fb73f53-d721-454a-9893-6b20a9fe9bf2.png">

### Notwendiges für die Ausführung: 
z.B.: Installationsprozess, Schritt für Schritt Anweisung, spezielles Packages welches geladen werden muss, etc.  

### Drittmaterial: 
Falls verwendet Fonts, Sounds, Music, Graphics, Materials, Code etc. welches nicht von mir stammt muss hier referenziert werden. 

### Anforderungsliste:      
- [x] WebGL export/upload lauffähig/spielbar
- [x] 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen
- [x] In Assets Folder MyGame anlegen.
- [x] Den Ordner Scenes in Assets > MyGame ziehen
- [x] Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene
- [x] Ein Canvas GameObject anlegen.
- [x] Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, 
das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.
- [x] In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.
- [x] In Asstets > MyGame den Folder Sprites anlegen. 
- [x] Ein Hintergrund Sprite reinladen.
- [x] In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.
- [x] Das Image ggf. positionieren und größentechnisch anpassen.
- [x] Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen. 
- [x] Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag. 
- [x] Das empty GameObject umbenennen in ParentTargets.
- [x] in Assets > MyGame > Prefabs Folder anlegen.
- [x] Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.
- [x] Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen. 
- [x] Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die 
- [x] Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen. 
- [x] In Assets > MyGame einen neuen Ordner anlegen Scripts
- [x] In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit Doppelklick öffnen in Visual Studio (https://github.com/HTL-SBG/FAQIssuesUnityVSGitGitHub/issues/2).
- [x] Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop). 
- [x] Einen 2D Collider als Komponente dem Target hinzufügen. 
- [x] Dem Script Target eine Methode OnMouseDown() hinzufügen. 
- [x] In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen
- [x] Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen. 
- [x] In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen. 
- [x] Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.
- [x] Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.
- [ ] ... (noch unvollständig)


### Limitationen:
Momentan keine :)

### Lessons Learned:
- [ ] Saturn
- [ ] Uranus
- [ ] Neptune
- [ ] Comet Haley

Copyright by lmadlen :)
