# WordGame (Wortkette)

## Projektbeschreibung

Im folgenden Beispiel wird ein Spiel programmiert, welches bei einem Wort ein neues Wort hinzufügt. Hierbei gelten folgende Regeln:

1. Das erste Wort kann beliebig eingegeben werden.
2. Der letzte Buchstabe des vorhandenen Wortes muss mit dem ersten Buchstaben des neuen Wortes übereinstimmen.
3. Die Groß- und Kleinschreibung wird ignoriert - die Überprüfung erfolgt mit Kleinbuchstaben.

> **Hinweis:** Ein falsches Wort (Buchstaben stimmen nicht überein) wird abgelehnt und kann nicht zur Kette hinzugefügt werden.

Um die Schwierigkeit zu erhöhen, können im Vorfeld bei einem Spiel Wörter ausgeschlossen werden (zB bei Tieren vielleicht die Wörter "Affe", "Bär" etc.). Wird ein ausgeschlossenens Wort verwendet so wird eine `WordNotAllowedException` ausgelöst.

Das Projekt wird in mehrere Teile aufgeteilt. In der Projektmappe (WordGame) werden folgende Projekte angelegt:

- WordGame.Core (Logik des Spiels)
- WordGame.Gui (.Net MAUI-Version)
- WordGame.Cli (Version für Konsole)
- WordGame.Tests (Softwaretests ... Juni 26)