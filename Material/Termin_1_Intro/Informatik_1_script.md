## Informationstechnologie I - Termin 1 Einführung (T4SST1005)

Sebastian Schwendemann, David Waidner

---

## Einführung

Programmieren ist eine Schlüsselkompetenz, deren Bedeutung in unserer digitalisierten Welt stetig zunimmt. Die Einsatzgebiete sind vielfältig und reichen von der Spieleentwicklung über Webanwendungen und Datenanalyse bis hin zur Maschinensteuerung und Automatisierung.

Doch warum ist Programmieren so wichtig? Es ermöglicht uns, wiederkehrnde Aufgaben zu automatisieren und komplexe Probleme durch die Entwicklung von Algorithmen systematisch zu lösen. In verschiedenen Fachgebieten kommen dabei unterschiedliche Technologien zum Einsatz. So wird beispielsweise in der Datenanalyse häufig Python verwendet, während in der Spieleentwicklung C# in Kombination mit der Unity-Engine eine große Rolle spielt. Eine wichtige Lernhaltung, die Sie von Anfang an verinnerlichen sollten, ist, dass Fehler ein normaler Teil des Programmierens sind. Das Suchen und Beheben von Fehlern, das sogenannte Debugging, ist ein integraler Bestandteil des Lernprozesses.

---

## Lernziele

Am Ende der heutigen Sitzung werden Sie in der Lage sein, ein erstes eigenes C#-Programm zu schreiben und auszuführen. Sie werden verstehen, was eine Variable ist und wie man sie verwendet, um Daten im Programm zu speichern. Darüber hinaus lernen Sie, mit `if-else`-Bedingungen Entscheidungen im Programmablauf zu modellieren und können grundlegende Datentypen in C# unterscheiden und anwenden.

Die konkrete Erwartung an Sie ist, dass Sie nach dieser Einheit ein kleines Programm selbstständig starten und nach Ihren Vorstellungen anpassen können. Die Übungsaufgaben dienen dabei primär dem Verständnis der Konzepte und nicht der Perfektion in der Umsetzung.

---

## Was ist (prozedurales) Programmieren?

Programmieren bedeutet im Kern, einem Computer eine Reihe von Schritt-für-Schritt-Anweisungen zu geben, um eine bestimmte Aufgabe zu erledigen. Jedes Programm besteht dabei aus zwei grundlegenden Komponenten: Daten, die verarbeitet werden, und Anweisungen, die definieren, wie diese Verarbeitung geschieht. In dieser Vorlesung konzentrieren wir uns auf das **prozedurale Programmieren**. Das bedeutet, dass die Befehle in einer festgelegten Reihenfolge nacheinander ausgeführt werden, ähnlich wie bei einem Kochrezept. Die typische Struktur eines prozeduralen Programms folgt dem Muster: **Eingabe → Verarbeitung → Ausgabe**.

Es gibt auch andere Programmierparadigmen wie die objektorientierte oder die funktionale Programmierung, die wir jedoch nur kurz zur Einordnung erwähnen. Die Analogie eines Rezepts veranschaulicht das prozedurale Konzept gut: Die Zutaten sind die Daten und die einzelnen Zubereitungsschritte sind die Anweisungen.

---

## Was ist ein Algorithmus?

Ein zentraler Begriff in der Informatik ist der **Algorithmus**. Ein Algorithmus ist eine eindeutige und endliche Abfolge von Schritten, die zur Lösung eines bestimmten Problems führt. Damit eine Anweisungsfolge als Algorithmus gilt, muss sie drei wesentliche Eigenschaften erfüllen:
1.  **Endlichkeit**: Der Algorithmus muss nach einer begrenzten Anzahl von Schritten zu einem Ergebnis kommen.
2.  **Eindeutigkeit**: Jeder Schritt muss klar und unmissverständlich formuliert sein, sodass es keine Zweifel an der Ausführung gibt.
3.  **Effektivität**: Jeder einzelne Schritt muss praktisch durchführbar sein.

Ein einfaches Beispiel für einen Algorithmus ist ein Sortierverfahren wie Bubble Sort, das eine Liste von Zahlen der Größe nach ordnet. Algorithmen sind die logische Grundlage für Programme und werden später in Form von Pseudocode oder direkt in einer Programmiersprache wie C# umgesetzt.

---

## Darstellungsmethoden für Algorithmen

Bevor ein Algorithmus in Code umgesetzt wird, ist es oft hilfreich, ihn in einer abstrakteren Form zu beschreiben. Zwei gängige Methoden dafür sind Pseudocode und Flowcharts.

### Pseudocode

Pseudocode ist eine informelle, textbasierte Beschreibung eines Algorithmus, die sich an der Struktur von Programmiersprachen orientiert, aber ohne deren strenge Syntaxregeln auskommt. Der Zweck von Pseudocode ist es, die Logik und den Ablauf eines Konzepts klar darzustellen. Einrückungen werden verwendet, um den Kontrollfluss, wie z. B. Bedingungen oder Schleifen, zu visualisieren.

Ein Beispiel für Pseudocode, der prüft, ob eine Zahl gerade oder ungerade ist, könnte so aussehen:

```
Lies Zahl ein
Wenn Zahl % 2 == 0 dann
    Ausgabe „Gerade“
Sonst
    Ausgabe „Ungerade“
Ende
```

Dieser Pseudocode lässt sich leicht in C#-Code übertragen, wobei die Bedingung `Wenn Zahl % 2 == 0` zu `if (zahl % 2 == 0)` wird. Ein präziser Pseudocode hilft, Implementierungsfehler zu vermeiden.

### Flowchart (Flussdiagramm)

Ein Flowchart ist eine grafische Darstellung eines Algorithmus. Verschiedene Symbole repräsentieren unterschiedliche Aktionen oder Entscheidungen:
- **Ovale** markieren den Start- und Endpunkt des Programms.
- **Parallelogramme** stehen für Eingabe- und Ausgabeoperationen (I/O), z. B. das Einlesen von Daten oder das Anzeigen von Ergebnissen.
- **Rauten** symbolisieren Entscheidungen, von denen aus der Programmfluss je nach Bedingung (wahr oder falsch) unterschiedliche Wege einschlägt.

Das folgende Diagramm zeigt den Algorithmus zur Prüfung auf eine gerade oder ungerade Zahl als Flowchart:

![Flow_Diagram](https://github.com/Rearth/DHBW-Vorlesung-Codespace/blob/main/Material/Bilder/algo_diagram.png?raw=true)

Flowcharts sind besonders nützlich, um komplexe Abläufe zu visualisieren, bevor der eigentliche Code geschrieben wird. Verzweigungen im Diagramm entsprechen `if/else`-Strukturen im Code.

---

## Programmieren in der Praxis mit C#

In der Praxis gibt es eine Vielzahl von Programmiersprachen wie Python, Java, C oder C#. In dieser Vorlesung verwenden wir **C#**, eine moderne und einsteigerfreundliche Sprache, die sich durch ein breites Einsatzgebiet auszeichnet. Sie wird für die Entwicklung von Desktop-Anwendungen, Web-Services, Spielen (insbesondere mit der Unity-Engine) und großen Unternehmensanwendungen genutzt.

Die Wahl fiel auf C#, weil es eine gute Balance zwischen einer einfachen, lesbaren Syntax und einer starken Typisierung bietet, was die Fehleranfälligkeit reduziert. Zudem gibt es eine Fülle an Lernressourcen und eine hervorragende Integration in Entwicklungsumgebungen (IDEs) wie Visual Studio oder Visual Studio Code mit Codespaces. Diese Werkzeuge unterstützen den Entwicklungsprozess durch Funktionen wie Autovervollständigung und Debugging. Ein wichtiger Hinweis für Ihren Lernprozess: Konzentrieren Sie sich auf die grundlegenden Programmierkonzepte. Wenn Sie diese einmal verstanden haben, können Sie sie leicht auf andere Programmiersprachen übertragen.

---

## Das erste „Hello World“ Programm in C#

Der traditionelle Einstieg in eine neue Programmiersprache ist das „Hello, World!“-Programm. In seiner einfachsten Form sieht es in C# so aus:

```c#
Console.WriteLine("Hello, World!");
```

Wenn dieses Programm ausgeführt wird, gibt es den Text „Hello, World!“ auf der Konsole aus und beendet sich anschließend. Dieser Code kann in einer Datei namens `Program.cs` innerhalb eines einfachen Konsolenprojekts ausgeführt werden. Moderne C#-Versionen unterstützen sogenannte „Top-Level-Statements“, die es erlauben, auf zusätzliches Rahmengerüst wie eine `Main`-Methode zu verzichten.

Typische Fehlerquellen bei diesem einfachen Programm sind vergessene Anführungszeichen um den Text oder ein fehlendes Semikolon am Ende der Zeile, was zu einem Compile-Fehler führen würde. Das Lernziel dieser Übung ist es, den Aufruf einer Methode zu verstehen und zu sehen, wie eine Ausgabe auf der Konsole erzeugt wird.

---

## Erklärung des „Hello World“-Programms

Lassen Sie uns den Code `Console.WriteLine("Hello, World!");` genauer analysieren:
-   `Console.WriteLine` ist ein **Funktionsaufruf** (genauer gesagt ein Methodenaufruf). `Console` ist eine Klasse aus dem `System`-Namensraum, die Funktionen für die Interaktion mit der Konsole bereitstellt, und `WriteLine` ist eine Methode dieser Klasse.
-   `("Hello, World!")` ist die **Übergabe eines Arguments** an die Methode. In diesem Fall wird ein Text (ein sogenannter `string`) übergeben, der auf der Konsole ausgegeben werden soll.
-   Das **Semikolon `;`** am Ende der Zeile markiert das Ende einer Anweisung und ist in C# obligatorisch.

Es gibt auch die Methode `Console.Write`, die im Gegensatz zu `WriteLine` keinen Zeilenumbruch nach der Ausgabe hinzufügt. Die Syntax für einen Methodenaufruf lautet allgemein `MethodenName(Argument1, Argument2, ...);`. Wenn der Compiler auf einen Fehler stößt, gibt er in der Regel die Zeilennummer und eine Beschreibung des Fehlers aus – es ist wichtig, diese Meldungen sorgfältig zu lesen.

---

## Die klassische Form eines C#-Programms

Während moderne C#-Versionen den Code durch Top-Level-Statements vereinfachen, ist es wichtig, die klassische, explizite Struktur eines Programms zu verstehen, da sie in größeren Projekten weiterhin Standard ist:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

Hier sind die einzelnen Bestandteile erklärt:
-   `using System;` bindet den `System`-Namensraum ein. Dadurch können wir `Console` direkt verwenden, anstatt den vollqualifizierten Namen `System.Console` schreiben zu müssen.
-   `class Program` definiert eine Klasse mit dem Namen `Program`. In C# ist jeder Code Teil einer Klasse.
-   `static void Main(string[] args)` ist die **Signatur der `Main`-Methode**. Sie ist der offizielle Einstiegspunkt des Programms. Die `args` (Argumente) sind ein Array von Zeichenketten, das verwendet wird, um dem Programm beim Start Parameter über die Kommandozeile zu übergeben.

Der Hauptgrund für die Einführung von Top-Level-Statements war es, diesen „Boilerplate“-Code für Einsteiger zu reduzieren. In der Praxis, insbesondere beim Debuggen, ist es sehr nützlich, Haltepunkte (Breakpoints) in der `Main`-Methode zu setzen, um die Ausführung des Programms zu analysieren.

---

## Erste Praxis: IDE-Setup mit GitHub Codespaces

Für die praktischen Übungen in dieser Vorlesung nutzen wir **GitHub Codespaces**. Dies ist eine cloudbasierte Entwicklungsumgebung, die direkt in Ihrem Browser läuft. Der große Vorteil ist, dass das Projekt bereits vorkonfiguriert ist, sodass alle Teilnehmer mit der exakt gleichen Umgebung arbeiten und wir keine Zeit mit lokaler Installation und Konfiguration verlieren.

Um zu beginnen, benötigen Sie lediglich einen kostenlosen GitHub-Account. Folgen Sie dann dem Template-Link, um Ihren eigenen Codespace für das Vorlesungsprojekt zu erstellen:

**Template-Link:** [https://github.com/Rearth/DHBW-Vorlesung-Codespace](https://github.com/Rearth/DHBW-Vorlesung-Codespace)

Sie können auch den folgenden QR-Code scannen, um direkt zur Seite zu gelangen:
![qrcode](https://github.com/Rearth/DHBW-Vorlesung-Codespace/blob/main/Material/Bilder/codespace_qr.png?raw=true)

---

## Erste Schritte im Codespace

Sobald Ihr Codespace gestartet ist, führen Sie die folgenden Schritte aus, um Ihr erstes Programm auszuführen:
1.  Öffnen Sie die Dateiansicht auf der linken Seite und wählen Sie die Datei `Program.cs` aus.
2.  Klicken Sie auf den grünen „Run“-Knopf (oft ein Pfeilsymbol) in der oberen rechten Ecke der Benutzeroberfläche.

Nachdem Sie auf „Run“ geklickt haben, wird im unteren Bereich des Editors ein Terminalfenster geöffnet. Dort können Sie den Build-Prozess beobachten. Wenn alles erfolgreich verläuft, sollte die Ausgabe "Hello, World!" im Terminal erscheinen. Falls die Ausgabe nicht angezeigt wird, stellen Sie sicher, dass die richtige Konfiguration (z. B. „Debug“) und das korrekte Projekt ausgewählt sind.

Ein großer Vorteil von Tools wie Codespaces ist die Möglichkeit, Änderungen live zu testen. Speichern Sie einfach die Datei, nachdem Sie eine Änderung vorgenommen haben, und führen Sie das Programm erneut aus.

Zusätzlich steht Ihnen in Codespaces der **GitHub Copilot Chat** zur Verfügung. Dieses KI-Tool kann Ihnen helfen, Code zu verstehen, Fehler zu erklären oder Konzepte zu erläutern. Nutzen Sie es idealerweise bei der selbstständigen Arbeit zu Hause. Denken Sie jedoch daran, dass KI-Tools nicht dazu gedacht sind, die kompletten Aufgaben für Sie zu lösen, und in der Prüfung nicht verfügbar sein werden.

---

## Erste Änderungen am Code

Machen wir uns nun mit dem Bearbeiten, Kompilieren und Ausführen von Code vertraut. Ändern Sie die Ausgabe in der `Program.cs`-Datei, zum Beispiel so:

```c#
Console.WriteLine("Mein erstes C#-Programm!");
```

Starten Sie das Programm anschließend erneut und beobachten Sie den Unterschied in der Ausgabe. Das Ziel dieser Übung ist es, ein Gefühl für den grundlegenden Arbeitsablauf zu bekommen: Code ändern, speichern, ausführen und das Ergebnis überprüfen. Fangen Sie klein an – schon das Ändern einer einzigen Zeile hilft dabei, sich mit der Umgebung vertraut zu machen.

---

## Variablen: Speicher für Daten

Eine **Variable** ist ein benannter Speicherort im Programm, der dazu dient, Daten zu halten, die während der Programmausführung benötigt werden. Die Zuweisung eines Wertes zu einer Variable erfolgt mit dem Gleichheitszeichen `=`.

In C# kann das Schlüsselwort `var` verwendet werden, um eine Variable zu deklarieren. Der Compiler leitet dann den Datentyp automatisch aus dem zugewiesenen Wert ab. Dies wird als **Typinferenz** bezeichnet. Wichtig ist hierbei, dass `var` nicht bedeutet, dass der Typ dynamisch ist. Der Datentyp wird zur Compile-Zeit fest bestimmt und kann danach nicht mehr geändert werden.

Eine Variable existiert nur innerhalb ihres **Gültigkeitsbereichs (Scope)**, zum Beispiel innerhalb einer Methode oder eines Codeblocks (gekennzeichnet durch `{}`). Es ist eine bewährte Praxis, eine Variable immer zu initialisieren, also ihr einen Anfangswert zuzuweisen, bevor sie zum ersten Mal verwendet wird.

---

## Beispiel: Variablen verwenden

Hier ist ein einfaches Beispiel, das die Verwendung von Variablen zur Berechnung einer Summe zeigt:

```c#
var zahl1 = 5;
var zahl2 = 7;
var summe = zahl1 + zahl2;
Console.WriteLine($"Summe: {summe}");
```

In diesem Code leitet der Compiler ab, dass `zahl1` und `zahl2` vom Typ `int` (Ganzzahl) sind. Folglich ist auch die Variable `summe` vom Typ `int`.

Die Ausgabe erfolgt mittels **String-Interpolation**, die durch ein `$` vor dem String eingeleitet wird. Dies ermöglicht es, Variablen direkt in den Text einzubetten, indem sie in geschweifte Klammern `{}` gesetzt werden, was den Code sehr gut lesbar macht.

Wenn Sie Operationen mit gemischten Datentypen durchführen, zum Beispiel `int` und `double` (eine Kommazahl), wendet C# eine automatische Typkonversion an. Das Ergebnis wird in der Regel der präzisere Datentyp sein. Dies ist ein wichtiges Detail, das man im Hinterkopf behalten sollte, insbesondere wenn es auf hohe Genauigkeit ankommt.

---

## Primitive Datentypen in C#

C# stellt eine Reihe von **primitiven Datentypen** zur Verfügung, die die grundlegenden Bausteine für die Datenspeicherung in einem Programm sind. Hier sind die wichtigsten:

-   **Ganzzahlen**:
    -   `int`: Der gebräuchlichste Typ für Ganzzahlen (z. B. `-10`, `0`, `123`).
    -   `long`: Für sehr große Ganzzahlen.
    -   `short`: Für kleinere Ganzzahlen, um Speicher zu sparen.
    -   `byte`: Für kleine, nicht-negative Ganzzahlen von 0 bis 255.

-   **Kommazahlen (Gleitkommazahlen)**:
    -   `double`: Der Standardtyp für Kommazahlen mit doppelter Genauigkeit.
    -   `float`: Ein Typ für Kommazahlen mit einfacher Genauigkeit. Er ist weniger präzise als `double`, benötigt aber auch weniger Speicher.

-   **Wahrheitswerte**:
    -   `bool`: Kann nur die Werte `true` (wahr) oder `false` (falsch) annehmen. Im Gegensatz zu einigen anderen Sprachen hat `bool` keine numerische Interpretation.

-   **Zeichen und Zeichenketten**:
    -   `char`: Repräsentiert ein einzelnes Zeichen (z. B. `'A'`). Technisch gesehen ist es ein 16-Bit-Unicode-Zeichen.
    -   `string`: Repräsentiert eine Kette von Zeichen, also Text (z. B. `"Hallo Welt"`).

Die Wahl des richtigen Datentyps hängt von den Anforderungen ab, insbesondere von der Größe der zu speichernden Werte und der benötigten Genauigkeit.

---

## Datentypen im Detail

Jeder Datentyp hat einen festen Speicherbedarf und einen daraus resultierenden Wertebereich. Die folgende Tabelle gibt einen Überblick über die wichtigsten primitiven Datentypen in C#:

| Typ | Vorzeichen | Größe | Wertebereich |
|---|---|---|---|
| `byte` | nein | 8 Bit | 0 bis 255 |
| `short` | ja | 16 Bit | -32.768 bis 32.767 |
| `int` | ja | 32 Bit | -2.147.483.648 bis 2.147.483.647 |
| `long` | ja | 64 Bit | ca. -9,2 × 10¹⁸ bis 9,2 × 10¹⁸ |
| `char` | nein | 16 Bit | Ein einzelnes 16-Bit-Unicode-Zeichen (0 bis 65.535) |
| `float` | ja | 32 Bit | ca. ±3,4 × 10³⁸ (mit 6-9 signifikanten Stellen) |
| `double` | ja | 64 Bit | ca. ±1,8 × 10³⁰⁸ (mit 15-17 signifikanten Stellen) |
| `bool` | - | 8 Bit | `true` oder `false` |

Das Wissen um diese Wertebereiche ist nützlich, um den passenden Datentyp auszuwählen und so Speicherplatz effizient zu nutzen. Bei Gleitkommazahlen (`float` und `double`) ist es wichtig, sich potenzieller Rundungsfehler bewusst zu sein. Daher sollte man beim Vergleich von zwei Gleitkommazahlen immer eine kleine Toleranz berücksichtigen, anstatt auf exakte Gleichheit zu prüfen.

---

## Datentypen bei der Zuweisung definieren

Wenn Sie eine Variable mit `var` deklarieren oder einen Wert direkt in einer Funktion verwenden, interpretiert C# den Datentyp anhand der Schreibweise des **Literals**:

-   `"Inhalt"`: Text in doppelten Anführungszeichen wird immer als `string` erkannt.
-   `'a'`: Ein einzelnes Zeichen in einfachen Anführungszeichen wird als `char` interpretiert.
-   `123`: Eine Zahl ohne Komma wird standardmäßig als `int` behandelt.
-   `123.45`: Eine Zahl mit einem Dezimalpunkt wird standardmäßig als `double` interpretiert. Beachten Sie, dass in C# (und den meisten Programmiersprachen) der Punkt als Dezimaltrennzeichen verwendet wird, auch wenn Ihre lokale Konsolenausgabe möglicherweise ein Komma anzeigt.
-   `true` / `false`: Diese Schlüsselwörter werden immer als `bool` erkannt.

Um die Lesbarkeit von großen Zahlen zu verbessern, können Sie numerische Trennzeichen verwenden, z. B. `1_000_000` anstelle von `1000000`.

---

## Spezifische Datentypen erzwingen

Manchmal möchten Sie sicherstellen, dass ein numerischer Wert als ein bestimmter Datentyp behandelt wird, auch wenn er standardmäßig anders interpretiert würde. Hierfür gibt es **Suffixe**, die Sie an das Literal anhängen können:

-   `123L`: Das Suffix `L` (oder `l`) erzwingt, dass die Zahl als `long` behandelt wird.
-   `123.45F`: Das Suffix `F` (oder `f`) erzwingt, dass die Gleitkommazahl als `float` behandelt wird. Dies ist notwendig, da `123.45` sonst als `double` interpretiert würde.
-   `123.45D`: Das Suffix `D` (oder `d`) kann optional verwendet werden, um explizit zu kennzeichnen, dass es sich um einen `double` handelt.

Die Verwendung von Suffixen ist besonders wichtig, wenn Sie mit Funktionen arbeiten, die spezifische numerische Typen als Argumente erwarten.

---

## Variablen in Strings ausgeben

Wie bereits erwähnt, ist die **String-Interpolation** eine elegante Methode, um die Werte von Variablen in einen String einzufügen. Dazu stellen Sie dem String ein `$`-Zeichen voran und schreiben die Variablennamen in geschweifte Klammern `{}`.

Beispiel:
```c#
var summe = 4 + 5;
Console.WriteLine($"Die Summe ist: {summe}");
```

Die String-Interpolation ist nicht nur auf das einfache Einfügen von Werten beschränkt. Sie können auch Format-Spezifizierer verwenden, um die Darstellung zu steuern. Zum Beispiel würde `{wert:0.00}` eine Zahl auf zwei Dezimalstellen runden.

Alternativen zur String-Interpolation sind die `String.Format`-Methode oder die klassische String-Verkettung mit dem `+`-Operator. Die Interpolation gilt jedoch als die modernste und am besten lesbare Methode.

---

## Beispielprogramm: Verschiedene Datentypen

Hier ist ein Beispielprogramm, das die Deklaration, Initialisierung und Ausgabe verschiedener primitiver Datentypen demonstriert:

```c#
int alter = 21;
double pi = 3.14159;
float temperatur = 36.6f; // Beachten Sie das 'f'-Suffix für float
char buchstabe = 'A';
bool istStudent = true;
string name = "Max";

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Alter: {alter}");
Console.WriteLine($"Ist Student: {istStudent}");
Console.WriteLine($"Lieblingsbuchstabe: {buchstabe}");
Console.WriteLine($"Körpertemperatur: {temperatur}");
Console.WriteLine($"Wert von Pi: {pi}");
```

Achten Sie bei der Deklaration der `temperatur`-Variable auf das `f`-Suffix. Ohne dieses würde der Compiler einen Fehler melden, da er versuchen würde, den `double`-Wert `36.6` einer `float`-Variable zuzuweisen. Dieses Beispiel zeigt auch, wie wichtig es ist, selbsterklärende Variablennamen zu verwenden, um die Lesbarkeit des Codes zu erhöhen.

---

## Konstanten: `const` und `readonly`

Manchmal möchten Sie Variablen definieren, deren Wert sich nach der ersten Zuweisung nicht mehr ändern soll. Dafür gibt es in C# zwei Schlüsselwörter: `const` und `readonly`.

-   `const`: Eine **Konstante**, deren Wert zur **Compile-Zeit** feststehen muss. Der Wert einer `const`-Variable kann sich zur Laufzeit des Programms niemals ändern. `const` wird typischerweise für universelle, unveränderliche Werte wie mathematische Konstanten (z. B. `const double Pi = 3.14159;`) verwendet. Der Compiler ersetzt Verwendungen von `const`-Variablen direkt durch deren Wert im Code.

-   `readonly`: Ein **schreibgeschütztes Feld**, dessen Wert entweder bei der Deklaration oder im **Konstruktor** einer Klasse zugewiesen werden kann. Danach ist der Wert für die Lebensdauer des Objekts unveränderlich. `readonly` ist nützlich für Werte, die von Laufzeitinformationen abhängen, aber nach der Initialisierung des Objekts konstant bleiben sollen (z. B. Konfigurationswerte).

Die Wahl zwischen `const` und `readonly` hängt also davon ab, ob der Wert bereits zur Compile-Zeit bekannt ist oder erst zur Laufzeit festgelegt wird.

---

## Operatoren in C#

Operatoren sind spezielle Symbole, die verwendet werden, um Operationen mit Variablen und Werten durchzuführen. C# bietet eine breite Palette von Operatoren, die in verschiedene Kategorien unterteilt werden können:

-   **Arithmetische Operatoren**: Werden für mathematische Berechnungen verwendet.
    -   `+` (Addition), `-` (Subtraktion), `*` (Multiplikation), `/` (Division)
    -   `%` (Modulo): Gibt den Rest einer ganzzahligen Division zurück.

-   **Zuweisungsoperatoren**: Werden verwendet, um Variablen Werte zuzuweisen.
    -   `=` (einfache Zuweisung)
    -   `+=`, `-=`, `*=`, `/=`: Kombinierte Zuweisungsoperatoren, die eine arithmetische Operation und eine Zuweisung in einem Schritt durchführen (z. B. `x += 2` ist eine Kurzform für `x = x + 2`).

-   **Vergleichsoperatoren**: Vergleichen zwei Werte und geben einen `bool`-Wert (`true` oder `false`) zurück.
    -   `==` (gleich), `!=` (ungleich)
    -   `<` (kleiner als), `>` (größer als)
    -   `<=` (kleiner oder gleich), `>=` (größer oder gleich)

-   **Logische Operatoren**: Werden verwendet, um `bool`-Werte zu kombinieren.
    -   `&&` (logisches UND): Gibt `true` zurück, wenn beide Bedingungen wahr sind.
    -   `||` (logisches ODER): Gibt `true` zurück, wenn mindestens eine Bedingung wahr ist.
    -   `!` (logisches NICHT): Kehrt den Wert einer `bool`-Bedingung um.

-   **Inkrement- und Dekrementoperatoren**: Erhöhen oder verringern einen ganzzahligen Wert um eins.
    -   `++` (Inkrement), `--` (Dekrement)

Es ist wichtig, die **Operatorpriorität** zu beachten (z. B. wird `*` vor `+` ausgeführt). Im Zweifelsfall sollten Sie Klammern verwenden, um die gewünschte Auswertungsreihenfolge klarzustellen. Beachten Sie auch, dass die ganzzahlige Division in C# immer abrundet (z. B. ist `5 / 2` gleich `2`). Die logischen Operatoren `&&` und `||` verwenden ein **Kurzschlussverhalten**: Wenn das Ergebnis bereits nach der Auswertung des ersten Operanden feststeht, wird der zweite Operand nicht mehr ausgewertet.

---

## Beispiele für Operatoren

### Arithmetische Operatoren

```c#
int a = 10;
int b = 3;

Console.WriteLine($"a + b = {a + b}"); // Ergebnis: 13
Console.WriteLine($"a - b = {a - b}"); // Ergebnis: 7
Console.WriteLine($"a * b = {a * b}"); // Ergebnis: 30
Console.WriteLine($"a / b = {a / b}"); // Ergebnis: 3 (Ganzzahldivision)
Console.WriteLine($"a % b = {a % b}"); // Ergebnis: 1 (Rest von 10 / 3)

// Um eine Gleitkommadivision zu erzwingen, muss einer der Operanden eine Gleitkommazahl sein.
// Dies kann durch einen sogenannten "Cast" erreicht werden:
Console.WriteLine($"(double)a / b = {(double)a / b}"); // Ergebnis: 3.333...
```

### Zuweisungsoperatoren

```c#
int x = 5;
x += 2; // Entspricht x = x + 2;
Console.WriteLine($"x nach += 2: {x}"); // Ergebnis: 7

x *= 3; // Entspricht x = x * 3;
Console.WriteLine($"x nach *= 3: {x}"); // Ergebnis: 21
```

### Vergleichsoperatoren

```c#
int a = 10;
int b = 3;

Console.WriteLine($"a == b: {a == b}"); // Ergebnis: false
Console.WriteLine($"a != b: {a != b}"); // Ergebnis: true
Console.WriteLine($"a > b: {a > b}");   // Ergebnis: true
Console.WriteLine($"a <= b: {a <= b}"); // Ergebnis: false
```

### Logische Operatoren

```c#
int a = 10;
int b = 3;

bool cond1 = (a > b) && (b > 0); // true UND true -> true
bool cond2 = (a < b) || (b > 0); // false ODER true -> true

Console.WriteLine($"(a > b) && (b > 0): {cond1}"); // Ergebnis: true
Console.WriteLine($"(a < b) || (b > 0): {cond2}"); // Ergebnis: true
Console.WriteLine($"! (a == b): {!(a == b)}");     // Ergebnis: true
```

### Inkrement- und Dekrementoperatoren

Hier ist der Unterschied zwischen **Post-Inkrement** (`i++`) und **Prä-Inkrement** (`++i`) wichtig:

```c#
int i = 0;
Console.WriteLine($"i = {i}"); // Ausgabe: 0

// Post-Inkrement: Der Wert von i wird *nach* der Auswertung des Ausdrucks erhöht.
Console.WriteLine($"i++: {i++}"); // Ausgabe: 0 (gibt den alten Wert zurück)
Console.WriteLine($"i danach: {i}"); // Ausgabe: 1

i = 0; // Zurücksetzen

// Prä-Inkrement: Der Wert von i wird *vor* der Auswertung des Ausdrucks erhöht.
Console.WriteLine($"++i: {++i}"); // Ausgabe: 1 (gibt den neuen Wert zurück)
```

---

## Interaktion mit dem Benutzer

Ein Programm wird erst dann richtig interaktiv, wenn es auf Eingaben des Benutzers reagieren kann. In C#-Konsolenanwendungen wird dies typischerweise mit der Methode `Console.ReadLine()` realisiert.

Diese Methode hält die Ausführung des Programms an und wartet, bis der Benutzer eine Zeile Text in die Konsole eingibt und mit der Enter-Taste bestätigt. Wichtig ist, dass `Console.ReadLine()` die Eingabe **immer als `string` (Zeichenkette) zurückgibt**, unabhängig davon, ob der Benutzer Zahlen oder Text eingegeben hat.

Wenn Sie die Eingabe als einen anderen Datentyp, z. B. eine Zahl, weiterverarbeiten möchten, müssen Sie sie explizit konvertieren. Die `Convert`-Klasse bietet hierfür passende Methoden:
-   `Convert.ToInt32(stringWert)`: Konvertiert einen String in einen `int`.
-   `Convert.ToSingle(stringWert)`: Konvertiert einen String in einen `float`.
-   `Convert.ToDouble(stringWert)`: Konvertiert einen String in einen `double`.

Es ist wichtig zu beachten, dass diese Konvertierungsmethoden eine Ausnahme (einen Fehler) auslösen, wenn der String nicht in den Zieldatentyp umgewandelt werden kann (z. B. wenn der Benutzer "Hallo" eingibt, aber eine Zahl erwartet wird). Für eine robustere Fehlerbehandlung, die wir später behandeln werden, gibt es `TryParse`-Methoden (z. B. `int.TryParse`).

Ein weiterer Punkt ist die Kulturabhängigkeit: Das Dezimaltrennzeichen kann je nach Ländereinstellung ein Punkt oder ein Komma sein. Für eine konsistente Verarbeitung kann es notwendig sein, explizit eine `CultureInfo` anzugeben.

---

## Beispiel: Benutzereingaben lesen und verarbeiten

Das folgende Beispiel zeigt, wie man den Namen und das Alter eines Benutzers einliest und darauf reagiert:

```c#
Console.WriteLine("Bitte gib deinen Namen ein:");
string name = Console.ReadLine();
Console.WriteLine($"Hallo, {name}!");

Console.WriteLine("Bitte gib dein Alter ein:");
string alterAlsText = Console.ReadLine();

// Die Eingabe (string) muss in einen Integer (int) umgewandelt werden.
int alter = Convert.ToInt32(alterAlsText);
Console.WriteLine($"Du bist also {alter} Jahre alt.");
```

In diesem Programm wird zuerst der Name als `string` eingelesen und direkt verwendet. Anschließend wird das Alter ebenfalls als `string` (`alterAlsText`) eingelesen. Da wir mit dem Alter möglicherweise rechnen oder es als Zahl vergleichen wollen, wandeln wir es mit `Convert.ToInt32()` in einen `int` um.

Dieses Beispiel verdeutlicht den wichtigen Schritt der **Typumwandlung (auch Parsing genannt)**, der bei der Verarbeitung von Benutzereingaben fast immer notwendig ist. Für eine robuste Anwendung sollten Sie immer damit rechnen, dass Benutzer ungültige Eingaben machen, und Ihr Programm darauf vorbereiten, anstatt abzustürzen.

---

## Kontrollstrukturen: `if-else`

**Kontrollstrukturen** ermöglichen es einem Programm, Entscheidungen zu treffen und den Programmfluss basierend auf bestimmten Bedingungen zu steuern. Die grundlegendste Kontrollstruktur ist die `if-else`-Anweisung.

Mit `if` können Sie einen Codeblock definieren, der nur dann ausgeführt wird, wenn eine bestimmte Bedingung `true` (wahr) ist. Optional können Sie einen `else`-Block hinzufügen, der ausgeführt wird, wenn die Bedingung `false` (falsch) ist.

Die Syntax sieht wie folgt aus:

```c#
int alter = 20;

if (alter >= 18)
{
    Console.WriteLine("Du bist volljährig.");
}
else
{
    Console.WriteLine("Du bist noch minderjährig.");
}
```

In diesem Beispiel wird die Bedingung `alter >= 18` ausgewertet. Da `20 >= 18` wahr ist, wird der Code innerhalb des `if`-Blocks ausgeführt. Wäre das Alter `16`, wäre die Bedingung falsch und der `else`-Block würde ausgeführt.

Die Bedingung in den runden Klammern muss immer einen `bool`-Wert (`true` oder `false`) ergeben. Es ist eine bewährte Praxis, die geschweiften Klammern `{}` immer zu verwenden, auch wenn ein Block nur aus einer einzigen Anweisung besteht. Dies verbessert die Lesbarkeit und hilft, Fehler zu vermeiden, wenn später weiterer Code hinzugefügt wird.

---

## Verschachtelte Bedingungen und `else if`

Manchmal müssen Sie mehrere Bedingungen nacheinander prüfen. Sie können `if`-Anweisungen ineinander **verschachteln**, aber dies kann schnell unübersichtlich werden. Eine sauberere und besser lesbare Alternative ist die Verwendung von `else if`.

Mit `else if` können Sie eine neue Bedingung prüfen, falls die vorherige `if`-Bedingung `false` war. Sie können beliebig viele `else if`-Blöcke aneinanderreihen. Ein optionaler `else`-Block am Ende fängt alle Fälle ab, in denen keine der vorherigen Bedingungen zutraf.

Hier ist ein Beispiel, das eine Schulnote bewertet:

```c#
int note = 2;

if (note == 1)
{
    Console.WriteLine("Sehr gut");
}
else if (note == 2)
{
    Console.WriteLine("Gut");
}
else if (note == 3)
{
    Console.WriteLine("Befriedigend");
}
else
{
    Console.WriteLine("Die Note ist ausreichend oder schlechter.");
}
```

Der Code prüft die Bedingungen von oben nach unten. Sobald eine Bedingung `true` ist, wird der zugehörige Block ausgeführt und der Rest der `if-else-if`-Kette wird übersprungen. In diesem Fall ist `note == 1` falsch, aber `note == 2` ist wahr, also wird "Gut" ausgegeben.

`else if`-Ketten sind sehr nützlich für die Abfrage von Zuständen. Wenn die Anzahl der zu prüfenden Fälle jedoch sehr groß wird, kann eine `switch`-Anweisung eine noch bessere Alternative sein.

---

## Die `switch`-Struktur

Die `switch`-Anweisung ist eine weitere Kontrollstruktur, die eine Variable mit einer Liste von möglichen Werten vergleicht. Sie ist oft lesbarer und effizienter als eine lange `if-else-if`-Kette, besonders wenn alle Vergleiche auf Gleichheit mit derselben Variable basieren.

Die Syntax sieht so aus:

```c#
int wochentag = 3;

switch (wochentag)
{
    case 1:
        Console.WriteLine("Montag");
        break;
    case 2:
        Console.WriteLine("Dienstag");
        break;
    case 3:
        Console.WriteLine("Mittwoch");
        break;
    // ... weitere Fälle für andere Wochentage
    default:
        Console.WriteLine("Das ist kein gültiger Wochentag.");
        break;
}
```

Die `switch`-Anweisung wertet die Variable in den runden Klammern aus (hier `wochentag`). Anschließend wird der Wert mit den Werten der einzelnen `case`-Marken verglichen. Wenn eine Übereinstimmung gefunden wird (hier `case 3`), wird der Codeblock unterhalb dieser Marke ausgeführt.

Das `break`-Schlüsselwort ist entscheidend: Es beendet die Ausführung des `switch`-Blocks. Ohne `break` würde der Code in den nächsten `case`-Block "durchfallen", was in C# (im Gegensatz zu einigen anderen Sprachen) nur unter bestimmten Bedingungen erlaubt ist und explizit angegeben werden muss.

Der `default`-Block ist optional und wird ausgeführt, wenn keiner der `case`-Werte mit dem Wert der Variable übereinstimmt. Er ist vergleichbar mit dem finalen `else`-Block in einer `if-else-if`-Kette.

Moderne C#-Versionen haben die `switch`-Anweisung um "Pattern Matching" erweitert, was noch flexiblere und mächtigere Vergleiche ermöglicht.

---

## Guter Programmierstil: Lesbarer Code

Guter Programmierstil ist entscheidend für die Wartbarkeit und Verständlichkeit von Software, besonders wenn man im Team arbeitet. Lesbarer Code ist leichter zu debuggen, zu erweitern und zu verstehen. Hier sind einige grundlegende Konventionen und Empfehlungen für C#:

-   **Namenskonventionen**:
    -   **PascalCase**: Für Klassen- und Methodennamen (z. B. `class MeineKlasse`, `void BerechneSumme()`). Jeder Wortanfang wird großgeschrieben.
    -   **camelCase**: Für lokale Variablennamen und Methodenparameter (z. B. `int meinAlter`, `string benutzerName`). Das erste Wort wird kleingeschrieben, die folgenden Wortanfänge groß.
    -   Verwenden Sie **aussagekräftige Namen**. Ein Name wie `benutzerAlter` ist weitaus besser als `bA` oder `x`.

-   **Kommentare**:
    -   Nutzen Sie Kommentare, um zu erklären, **warum** etwas auf eine bestimmte Weise implementiert wurde, nicht **was** der Code tut. Der Code selbst sollte so lesbar sein, dass er das "Was" erklärt.
    -   In C# werden einzeilige Kommentare mit `//` eingeleitet.

-   **Formatierung**:
    -   Verwenden Sie eine **konsistente Einrückung** (typischerweise 4 Leerzeichen pro Ebene), um die Struktur des Codes (z. B. innerhalb von `if`-Blöcken oder Schleifen) klar hervorzuheben. Die meisten Code-Editoren formatieren dies automatisch.

-   **Sprache**:
    -   In der professionellen Softwareentwicklung ist es üblich, Code (Variablennamen, Kommentare etc.) vollständig auf **Englisch** zu schreiben, um die internationale Zusammenarbeit zu erleichtern.

Ein konsistenter Stil ist wichtiger als die Einhaltung einer einzelnen, starren Regel. Viele Teams definieren ihre eigenen Stilrichtlinien. Das Ziel ist immer, Code zu schreiben, den andere (und man selbst in sechs Monaten) leicht verstehen können. Dazu gehört auch, Methoden kurz zu halten und ihnen nur eine einzige, klar definierte Aufgabe zu geben (Single Responsibility Principle).

---

## Typische Stolpersteine für Anfänger

Beim Erlernen einer neuen Programmiersprache gibt es einige typische Fehler, die Anfängern häufig unterlaufen. Sich dieser bewusst zu sein, kann helfen, sie schneller zu erkennen und zu beheben:

-   **Vergessenes Semikolon (`;`)**: In C# muss fast jede Anweisung mit einem Semikolon abgeschlossen werden. Ein fehlendes Semikolon ist einer der häufigsten Compiler-Fehler.

-   **Groß- und Kleinschreibung**: C# ist eine **case-sensitive** Sprache. Das bedeutet, dass die Variable `alter` nicht dieselbe ist wie `Alter`. Achten Sie genau auf die Schreibweise.

-   **Zuweisung (`=`) vs. Vergleich (`==`)**: Ein sehr häufiger Fehler ist die Verwendung des Zuweisungsoperators `=` in einer `if`-Bedingung, wo eigentlich der Vergleichsoperator `==` hingehört. `if (alter = 18)` würde versuchen, der Variable `alter` den Wert 18 zuzuweisen, anstatt zu prüfen, ob sie gleich 18 ist. Moderne Compiler geben hier oft eine Warnung aus.

-   **Strings und Chars**: Denken Sie an den Unterschied bei den Anführungszeichen:
    -   Strings (Zeichenketten) werden in doppelte Anführungszeichen (`"..."`) eingeschlossen.
    -   Chars (einzelne Zeichen) werden in einfache Anführungszeichen (`'...'`) eingeschlossen.

Es ist wichtig, zwischen **Compiler-Fehlern** (der Code kann nicht gebaut werden) und **Laufzeit-Fehlern** (das Programm stürzt während der Ausführung ab) zu unterscheiden. Lesen Sie Fehlermeldungen immer sorgfältig – sie enthalten wertvolle Hinweise auf die Ursache des Problems. Ein besonders häufiger Laufzeitfehler ist die `NullReferenceException`, die auftritt, wenn man versucht, auf eine Variable zuzugreifen, die keinen Wert (also `null`) hat.

---

## Was ist C# und .NET?

Um C# vollständig zu verstehen, ist es wichtig, die Beziehung zwischen der Sprache und der Plattform, auf der sie läuft, zu kennen.

-   **C#** ist die **Programmiersprache**, die von Microsoft entworfen wurde. Sie definiert die Syntax, die Schlüsselwörter und die grammatikalischen Regeln, die Sie beim Schreiben von Code verwenden. C# ist eine moderne, objektorientierte und stark typisierte Sprache. "Stark typisiert" bedeutet, dass der Datentyp jeder Variable zur Compile-Zeit bekannt sein muss, was viele Fehler frühzeitig aufdeckt.

-   **.NET** (früher auch .NET Framework oder .NET Core genannt) ist die **Plattform** und das **Framework**, das die notwendige Laufzeitumgebung und eine umfangreiche Sammlung von Bibliotheken bereitstellt, um C#-Anwendungen (und Anwendungen in anderen .NET-Sprachen wie F# oder VB.NET) zu entwickeln und auszuführen.

Das Hauptziel von .NET ist es, eine produktive Entwicklungsumgebung mit einer breiten Bibliotheksunterstützung zu bieten. Seit der Einführung von .NET Core (und den Nachfolgern .NET 5, 6, etc.) ist .NET **plattformübergreifend**, was bedeutet, dass Ihre Anwendungen auf Windows, macOS und Linux laufen können.

Typische Anwendungsfälle für C# und .NET sind:
-   **Webanwendungen** mit ASP.NET Core
-   **Desktop-Anwendungen** für Windows (mit WPF oder WinForms)
-   **Spieleentwicklung**, insbesondere mit der Unity-Engine
-   **Cloud-Dienste**, Microservices und serverseitige Anwendungen
-   **Mobile Apps** mit MAUI oder Xamarin

Die Konzepte, die Sie in C# lernen, wie das Typsystem, die Speicherverwaltung (Garbage Collection) und die Struktur von Assemblies, sind in all diesen Anwendungsbereichen relevant.

---

## Vom C#-Code zum ausführbaren Programm

Der Weg von Ihrem geschriebenen C#-Code zu einem Programm, das der Computer ausführen kann, verläuft in mehreren Schritten. Dieser Prozess wird von der .NET-Plattform gesteuert.

1.  **C#-Quellcode → Compiler (Roslyn) → Intermediate Language (IL)**
    Zuerst wird Ihr C#-Quellcode (`.cs`-Dateien) vom **Roslyn-Compiler** analysiert und in eine sogenannte **Intermediate Language (IL)** oder auch **Microsoft Intermediate Language (MSIL)** übersetzt. IL ist ein plattformunabhängiger Zwischencode. Er ist noch kein Maschinencode, der direkt von einer CPU ausgeführt werden kann.

2.  **Assemblies (.dll oder .exe)**
    Die IL wird zusammen mit **Metadaten** in einer Datei gespeichert, die als **Assembly** bezeichnet wird. Eine Assembly hat entweder die Dateiendung `.dll` (Dynamic Link Library, eine Bibliothek) oder `.exe` (Executable, ein ausführbares Programm). Die Metadaten beschreiben die Typen (Klassen, Methoden etc.), die in der Assembly definiert sind, sowie die Abhängigkeiten zu anderen Assemblies. Diese Struktur ermöglicht die Portabilität von .NET-Anwendungen.

Für das Debugging werden zusätzlich **PDB-Dateien** (`.pdb`) erzeugt, die Symbolinformationen enthalten. Sie ordnen den IL-Code dem ursprünglichen C#-Quellcode zu, was es dem Debugger ermöglicht, den Code schrittweise auf Quellcode-Ebene auszuführen.

---

## Die .NET-Laufzeitumgebung (Runtime)

Wenn Sie eine .NET-Anwendung starten, übernimmt die **.NET-Laufzeitumgebung** (oft als **Common Language Runtime (CLR)** in älterer Terminologie oder einfach **.NET Runtime** bezeichnet) die Kontrolle. Sie stellt die Umgebung bereit, in der der IL-Code ausgeführt wird.

Die Hauptaufgaben der Runtime sind:
-   **Just-In-Time (JIT) Compilation**: Die Runtime enthält einen **JIT-Compiler**, der die plattformunabhängige IL zur Laufzeit (also während das Programm läuft) in **nativen Maschinencode** übersetzt, der spezifisch für die CPU-Architektur des ausführenden Computers ist. Moderne Runtimes wie **RyuJIT** verwenden optimierende Techniken wie "Tiered Compilation", bei der Code zuerst schnell und später optimiert kompiliert wird.
-   **Speicherverwaltung**: Die Runtime verwaltet den Speicher für die Anwendung automatisch. Ein zentraler Bestandteil davon ist der **Garbage Collector (GC)**, den wir später genauer betrachten.
-   **Typsicherheit**: Die Runtime stellt sicher, dass Typumwandlungen und Speicherzugriffe sicher sind, um die Stabilität des Programms zu gewährleisten.
-   **Exception Handling**: Sie kümmert sich um die Behandlung von Ausnahmen (Laufzeitfehlern).

Es gibt verschiedene Implementierungen der .NET-Runtime, z. B. die **CoreCLR** (die Standard-Runtime für moderne .NET-Versionen) und **Mono** (eine Open-Source-Implementierung, die z. B. von Unity verwendet wird). Für spezielle Szenarien gibt es auch **Ahead-of-Time (AOT)**-Compiler, die den Code bereits vor der Ausführung in nativen Code übersetzen.

---

## Tools und das .NET-Ökosystem

Das .NET-Ökosystem besteht aus einer Vielzahl von Werkzeugen, die den Entwicklungsprozess unterstützen:

-   **Compiler und SDK**:
    -   **Roslyn**: Der moderne C#-Compiler, der nicht nur für die Übersetzung zuständig ist, sondern auch APIs für Code-Analyse und Refactoring bereitstellt. Diese APIs werden von IDEs genutzt, um Features wie "Code-Fixes" anzubieten.
    -   **dotnet CLI**: Das Kommandozeilen-Interface (`dotnet`) ist das zentrale Werkzeug zur Verwaltung von .NET-Projekten. Mit Befehlen wie `dotnet build`, `dotnet run` und `dotnet publish` können Sie Projekte erstellen, ausführen und veröffentlichen. Das **.NET SDK (Software Development Kit)** enthält die CLI, den Compiler und die Standardbibliotheken.

-   **Build-System und Paketverwaltung**:
    -   **MSBuild**: Das Build-System, das den Kompilierungsprozess orchestriert, Ressourcen einbettet und Pakete erstellt.
    -   **NuGet**: Der Paketmanager für .NET. Er ermöglicht es Entwicklern, Bibliotheken von Drittanbietern (sogenannte NuGet-Pakete) einfach in ihre Projekte einzubinden und zu verwalten.

-   **Entwicklungsumgebungen (IDEs)**:
    -   **Visual Studio**: Die voll ausgestattete IDE von Microsoft für die Windows-Entwicklung.
    -   **Visual Studio Code (VS Code)**: Ein leichtgewichtiger, plattformübergreifender Code-Editor, der durch Erweiterungen (insbesondere die C#-Erweiterung) zu einer leistungsstarken Entwicklungsumgebung wird.
    -   **JetBrains Rider**: Eine beliebte, plattformübergreifende .NET-IDE von JetBrains.

---

## Unter der Haube: Garbage Collector und JIT/AOT

Zwei der wichtigsten Konzepte der .NET-Laufzeitumgebung, die die Leistung und Stabilität von Anwendungen maßgeblich beeinflussen, sind der Garbage Collector und die Art der Kompilierung.

-   **Garbage Collector (GC)**:
    Der GC ist für die **automatische Speicherbereinigung** zuständig. In C# müssen Sie sich (meistens) nicht manuell um die Freigabe von Speicher kümmern, der von Objekten belegt wird, die nicht mehr benötigt werden. Der GC identifiziert diese ungenutzten Objekte und gibt ihren Speicher frei. Er arbeitet mit einem **Generationenmodell (Generation 0, 1 und 2)**. Die Idee dahinter ist, dass die meisten Objekte nur eine sehr kurze Lebensdauer haben. Der GC durchsucht daher am häufigsten die "junge" Generation 0, was sehr effizient ist. Es gibt verschiedene GC-Modi, z. B. einen "Workstation"-Modus für Desktop-Anwendungen und einen "Server"-Modus für serverseitige Anwendungen mit hohem Durchsatz.

-   **Just-In-Time (JIT) vs. Ahead-of-Time (AOT) Compilation**:
    -   **JIT**: Wie bereits erwähnt, übersetzt der JIT-Compiler den IL-Code zur Laufzeit in nativen Code. Dies ermöglicht profilbasierte Optimierungen, da der JIT-Compiler beobachten kann, welche Codepfade häufig genutzt werden, und diese besonders effizient kompilieren kann. Der Nachteil ist ein gewisser "Warm-up"-Overhead beim Start der Anwendung.
    -   **AOT**: Bei der AOT-Kompilierung wird der gesamte Code bereits vor der Ausführung in nativen Code übersetzt. Dies führt zu **schnelleren Startzeiten** und kann in Umgebungen nützlich sein, in denen ein JIT-Compiler nicht erlaubt oder erwünscht ist (z. B. auf iOS oder in kleinen Containern). Der Nachteil ist, dass die zur Laufzeit möglichen Optimierungen des JIT-Compilers entfallen und die erzeugten Binärdateien größer sein können. Native AOT ist ein wichtiger Fokus in modernen .NET-Versionen.

Für die Leistungsanalyse und das Debugging von Performance-Problemen stellt .NET eine Reihe von Profiling-Tools wie `dotnet-trace` und `dotnet-counters` sowie den integrierten Profiler in Visual Studio zur Verfügung.

---

## Zusammenfassung der heutigen Sitzung

In der heutigen Vorlesung haben wir die grundlegenden Bausteine der Programmierung mit C# kennengelernt.

Sie haben gelernt, wie Sie:
-   Ein erstes, einfaches C#-Programm schreiben und in der Entwicklungsumgebung ausführen.
-   **Variablen** verwenden, um Daten zu speichern, und die wichtigsten **primitiven Datentypen** wie `int`, `double`, `bool` und `string` unterscheiden.
-   **Operatoren** für arithmetische Berechnungen, Vergleiche und logische Verknüpfungen einsetzen.
-   Mit `Console.ReadLine()` **Benutzereingaben** entgegennehmen und diese mittels Typumwandlung weiterverarbeiten.
-   Den Programmfluss mit **Kontrollstrukturen** wie `if-else` und `switch` steuern, um Entscheidungen im Code zu treffen.

Der Fokus lag heute darauf, ein grundlegendes Verständnis für diese Kernkonzepte zu entwickeln, anstatt eine perfekte Syntax zu beherrschen. Als nächste Schritte wird empfohlen, die kleinen Programmieraufgaben zu Hause zu wiederholen und bei Unklarheiten die offizielle Microsoft-Dokumentation zu konsultieren.

Denken Sie daran: Fehler sind eine hervorragende Lernchance. Das systematische Suchen und Beheben von Fehlern – das **Debugging** – ist eine der wichtigsten Fähigkeiten, die Sie als Entwickler erlernen werden.
