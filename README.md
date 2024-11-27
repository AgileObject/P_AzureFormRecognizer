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

   ![image](https://github.com/user-attachments/assets/927bdd64-8aa1-4949-9d8f-67dee6a51268)

2. Anlegen einer Instance für die Azure Document Intelligence

   ![image](https://github.com/user-attachments/assets/e49ab16d-cbc2-4395-8fae-0764d662a237)

### Konfiguration Azure Key und Endpoint im AzureFormRecognizer

Übernahme des Keys und des Endpoints in die Konfiguration

   ![image](https://github.com/user-attachments/assets/a15510e1-c02c-431b-9946-643d175ccbcc)

### Erforderliche Pakete

![image](https://github.com/user-attachments/assets/2abdf11c-a3a5-4297-bb7b-b8fb33b2e1b5)

![image](https://github.com/user-attachments/assets/74fed754-819c-4e41-8107-d58e0a8d25d6)

Bei der Verwendung der jeweiligen Pakete sind die entsprechenden Lizenzvereinbarungen zu berücksichtigen.


## Programmaufbau

![image](https://github.com/user-attachments/assets/a77d134d-5c36-4c21-99d1-2dd8787b35a1)

![image](https://github.com/user-attachments/assets/a100cd58-7a83-41ca-9ce9-ea2c035e30bc)


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



