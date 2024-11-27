# AzureFormRecognizer

## Allgemein - Was ist der AzureFormRecognizer

Dieses Programm ist eine ganze simple Windows Forms-Anwendung, die die ***Azure Form Recognizer API*** (***Azure Document Intelligence***) verwendet, um Text aus einem ausgewählten Dokument zu extrahieren und diesen Text in ein durchsuchbares PDF-Dokument (***searchable PDF***) zu konvertieren.

Hier ist eine kurze Zusammenfassung der Hauptfunktionen:
1.	Initialisierung:
> •	Lädt ein Bild in ein PictureBox-Steuerelement.
> 
> •	Initialisiert die Azure Form Recognizer API mit Endpunkt und API-Schlüssel aus der Konfigurationsdatei.
2.	Dateiauswahl:
> •	Ermöglicht dem Benutzer, eine Datei auszuwählen, die dann im PictureBox-Steuerelement angezeigt wird.
3.	Textanalyse und PDF-Erstellung:
> •	Verwendet die Azure Form Recognizer API, um Text aus der ausgewählten Datei zu extrahieren.
> 
> •	Erstellt ein durchsuchbares PDF-Dokument mit dem extrahierten Text.
4.	PDF-Anzeige:
> •	Öffnet das erstellte PDF-Dokument im Standard-PDF-Viewer des Systems.
5.	Schließen der Anwendung:
> •	Schließt die Anwendung, wenn der Benutzer auf die Schaltfläche "Schließen" klickt.


## Requirements

> • Eine Visual Studio 2022 Entwicklungsumgebung

> • .NET 8.0 oder höher

> • Eine Microsoft Azure Subscription


## Preparation

### Konfiguration der Azure Document Intelligence

1. Anlegen einer Ressourcengruppe

   ![image](https://github.com/user-attachments/assets/a8b65b02-5dc0-4c0b-86ee-43c9b1eabbdb)

3. Anlegen einer Instance für die Azure Document Intelligence

   ![image](https://github.com/user-attachments/assets/0615a53d-a830-4120-a97f-19d324afdd52)

### Konfiguration Azure Key und Endpoint im AzureFormRecognizer

Übernahme des Keys und des Endpoints in die Konfiguration

   ![image](https://github.com/user-attachments/assets/b4ab57d9-3028-4c8b-aa33-b1556c22cf0d)

### Erforderliche Pakete

![image](https://github.com/user-attachments/assets/161094e6-859c-4361-8ef5-270a83f3a5a2)

![image](https://github.com/user-attachments/assets/3406bb88-b804-47d9-80e4-71b48ce225dd)

Bei der Verwendung der jeweiligen Pakete sind die entsprechenden Lizenzvereinbarungen zu berücksichtigen.


## Programmaufbau

![image](https://github.com/user-attachments/assets/3b112dbc-0f51-4f01-844a-64c0a4004b1c)

![image](https://github.com/user-attachments/assets/e9ed6af6-2ffa-4ccc-ae99-5e8929a645a3)


## Beispiele

Programmstart

![image](https://github.com/user-attachments/assets/09c4655f-9e31-4942-a744-17d05094e0cf)

Datei auswählen

![image](https://github.com/user-attachments/assets/ad8f5bab-4178-40db-a2dc-14a3874690ee)

![image](https://github.com/user-attachments/assets/acf1a08b-e2da-4020-b82e-994621bca500)

Create searchable PDF

Hinter dem Button erscheint nach dem Generieren des PDF's ein Häkchen...

![image](https://github.com/user-attachments/assets/69a0061f-1f20-41f8-aa2d-3f087d4cc78e)

Open Result

![image](https://github.com/user-attachments/assets/2c37c3b7-8afc-4036-a370-6768c93ee5ae)

Searchable PDF

![image](https://github.com/user-attachments/assets/ba1f13ef-a012-4c72-a3f0-183b4bb9f445)



