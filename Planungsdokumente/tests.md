# Testfall: Hinzufügen eines neuen Beckens

**ID:** T01

**Beschreibung:** Hinzufügen eines neuen Beckens.

**Vorbedingung:** Der Button „Hinzufügen“ im Becken-Verwaltung Register funktioniert.

**Test-Schritte:**

1.  Projekt starten.
2.  Im Register „Becken-Verwaltung“ auf „Hinzufügen“ klicken.
3.  Alle TextBoxen ausfüllen und auf den Button „Hinzufügen“ klicken.

**Erwartetes Resultat:** Die Angaben wurden übernommen und in die Datenbank eingebunden.

# Testfall: Löschen eines Beckens

**ID:** T02

**Beschreibung:** Löschen eines vorhandenen Beckens.

**Vorbedingung:**
* Ein Becken existiert in der Datenbank.
* Der Button „Löschen“ im Becken-Verwaltung Register funktioniert.

**Test-Schritte:**

1.  Projekt starten.
2.  Im Register „Becken-Verwaltung“ das zu löschende Becken auswählen.
3.  Auf den Button „Löschen“ klicken.
4.  Die Löschung im Bestätigungsdialog bestätigen.

**Erwartetes Resultat:** Das ausgewählte Becken wurde erfolgreich aus der Datenbank entfernt und ist nicht mehr in der Becken-Verwaltung sichtbar.