### Aufgabe 1: Postleitzahl prüfen

**Ziel:** Länge und Inhalt einer Postleitzahl prüfen.

**Anforderungen:**

1. Lesen Sie eine Postleitzahl als Text ein; führende Nullen bleiben erhalten.
2. Prüfen Sie, ob sie genau 5 Codeeinheiten lang ist und ausschließlich die Ziffern `0` bis `9` enthält.
3. Geben Sie getrennt aus, ob Länge und Inhalt passen. Gültig ist sie nur, wenn beides erfüllt ist.

**Testfälle:** `"01234"` → gültig; `"1234"` → Länge falsch; `"12a45"` → Inhalt falsch; `""` → ungültig.

**Tipp:** Kombinieren Sie `Length`, eine Schleife und Zeichenvergleiche.

### Aufgabe 2: Vokale zählen

**Ziel:** Die Vokale `a`, `e`, `i`, `o`, `u` in einem Text zählen.

**Anforderungen:**

1. Lesen Sie einen Text ein und durchlaufen Sie ihn mit `foreach`.
2. Zählen Sie Vokale unabhängig von Groß-/Kleinschreibung.
3. Geben Sie Anzahl der Vokale und Gesamtzahl der Codeeinheiten aus.

**Testfälle:** `"Hallo Welt"` → 3 Vokale bei Länge 10; `"AEIOU"` → 5 bei Länge 5; `""` → 0 bei Länge 0.

**Tipp:** Überlegen Sie, welche Variable über alle Durchläufe hinweg erhalten bleiben muss.

### Aufgabe 3: Passwortanalyse

**Ziel:** Mehrere Eigenschaften eines Texts untersuchen.

**Anforderungen:**

1. Lesen Sie einen erfundenen Passworttext ein.
2. Prüfen Sie: mindestens 8 Codeeinheiten, mindestens eine Ziffer und mindestens ein Großbuchstabe.
3. Melden Sie für jedes Kriterium, ob es erfüllt ist, und geben Sie ein Gesamtergebnis aus.

**Testfälle:** `"Hallo123"` → alle erfüllt; `"hallo123"` → Großbuchstabe fehlt; `"A1"` → zu kurz; `""` → keines erfüllt.

**Tipp:** Welche Informationen müssen Sie sich während der Schleife merken?

### Aufgabe 4: Text umkehren

**Ziel:** Die umgekehrte Reihenfolge eines Texts selbst erzeugen.

**Anforderungen:**

1. Lesen Sie einen Text aus einfachen Buchstaben und Leerzeichen ein.
2. Erzeugen Sie mit einer Schleife und einem Ergebnis-String den Text in umgekehrter Reihenfolge. Verwenden Sie keine fertige Umkehrfunktion.
3. Geben Sie Original und Ergebnis aus.

**Testfälle:** `"Hallo"` → `"ollaH"`; `"Ab C"` → `"C bA"`; `"A"` → `"A"`; `""` → `""`.

**Tipp:** Skizzieren Sie zunächst die gewünschte Reihenfolge der Zugriffe für `"ABC"`.

### Aufgabe 5: Antworten vereinheitlichen

**Ziel:** Benutzereingaben trotz unterschiedlicher Schreibweise erkennen.

**Anforderungen:**

1. Lesen Sie eine Antwort auf eine Ja-/Nein-Frage ein.
2. Akzeptieren Sie `"ja"` und `"j"` sowie `"nein"` und `"n"`, unabhängig von Groß-/Kleinschreibung und Whitespace an den Rändern.
3. Geben Sie „Bestätigt“, „Abgelehnt“ oder „Unbekannte Antwort“ aus.

**Testfälle:** `"  jA "`, `"J"` → bestätigt; `" N "` → abgelehnt; `"j a"`, `""` → unbekannt.

**Tipp:** Trennen Sie Bereinigung und Entscheidung gedanklich voneinander.

### Aufgabe 6: Palindrom-Prüfung

**Ziel:** Prüfen, ob ein Wort vorwärts und rückwärts gleich ist.

**Anforderungen:**

1. Lesen Sie ein Wort aus einfachen Buchstaben ein; weisen Sie eine leere Eingabe ab.
2. Ignorieren Sie die Groß-/Kleinschreibung.
3. Vergleichen Sie mit einer `for`-Schleife Zeichenpaare von außen bis zur Mitte. Brechen Sie bei einem Unterschied ab.
4. Geben Sie das Ergebnis nach der Prüfung aus.

**Testfälle:** `"Anna"`, `"Lagerregal"`, `"A"` → ja; `"Auto"` → nein; `""` → ungültige Eingabe.

**Tipp:** Zeichnen Sie die Paare für ein Wort mit 5 und eines mit 6 Buchstaben ein.

### Aufgabe 7: E-Mail-Adresse zerlegen

**Ziel:** Einen strukturierten Text prüfen und in zwei Teile zerlegen.

**Anforderungen:**

1. Lesen Sie eine E-Mail-Adresse ein und entfernen Sie Whitespace an den Rändern.
2. Verlangen Sie genau ein `@` und nicht leeren Text auf beiden Seiten.
3. Geben Sie Benutzerteil und Domain getrennt aus. Melden Sie bei verletzten Regeln einen Fehler.

**Testfälle:** `" anna@dhbw.de "` → `"anna"` / `"dhbw.de"`; `"anna"`, `"@dhbw.de"`, `"anna@"`, `"a@@b"` → Fehler.

**Tipp:** Planen Sie zuerst die Prüfungen und danach die Teiltexte.

### Aufgabe 8: Suchtext ersetzen

**Ziel:** Einen Text bearbeiten und das Ergebnis mit dem Original vergleichen.

**Anforderungen:**

1. Lesen Sie einen Satz und einen nicht leeren Suchtext ein.
2. Ersetzen Sie alle passenden Vorkommen durch `"****"`.
3. Geben Sie Original und Ergebnis aus. Melden Sie außerdem, ob etwas ersetzt wurde.

**Testfälle:** Satz `"Test und Testlauf"`, Suche `"Test"` → `"**** und ****lauf"`; Suche `"test"` → unverändert; Suche `""` → Fehlermeldung.

**Tipp:** Die Ersetzung berücksichtigt hier Groß-/Kleinschreibung und trifft auch Teilwörter.

### Aufgabe 9: Wörter zählen

**Ziel:** Wörter auch bei mehreren Leerzeichen korrekt zählen.

**Anforderungen:**

1. Lesen Sie einen Satz ein; als Trenner gilt hier nur `' '`.
2. Zählen Sie mit einer Schleife nicht leere Wortabschnitte. Nutzen Sie kein `Split()`.
3. Mehrere Leerzeichen sowie Leerzeichen am Anfang und Ende dürfen keine zusätzlichen Wörter erzeugen.

**Testfälle:** `"Hallo Welt"` → 2; `"  Hallo   Welt  "` → 2; `""` und `"   "` → 0; `"Hallo,Welt"` → 1.

**Tipp:** Wann beginnt ein neues Wort? Überlegen Sie, welche Information aus dem vorherigen Durchlauf hilft.
