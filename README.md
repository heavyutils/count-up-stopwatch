# Count-Up Stopwatch
A minimal stopwatch for speedruns and the like.

## Introduction
WELCOME TO COUNT-UP STOPWATCH! - 
This is an extremely simple stopwatch, with military-grade tracking of elapsed time, down to milliseconds. There are zero unnecessary interfaces, only the clock, and, if enabled, timer start delay UI. There are no buttons though; you will rely on hotkeys. The keys are mapped similar to many game layouts, for compact and easy access. You can also use the new context menu by right-clicking it, if you prefer.


BASIC CONTROLS - 
	Space: Startnstop timer,
	E: Startnstop timer,
	R: Reset timer,
	Mouse Button Hold: Drag window around,
	Alt+F4: Close window.


DETAILED VIEW - SHOWS FRACTIONS OF SECOND INSTEAD OF HOURS - 
	Q: Toggle detailed view (default on)
 
You can see if detailed view is on by checking whether the decimal
point is there. You can't use detailed view if an hour has elapsed.


TIMER START COUNTDOWNS - DELAY THE START OF THE STOPWATCH - 
	0: Set timer start countdown to 0S,
	1: Set timer start countdown to 1S,
	2: Set timer start countdown to 2S,
	3: Set timer start countdown to 3S,
	4: Set timer start countdown to 4S,
	5: Set timer start countdown to 5S,
	6: Set timer start countdown to 6S,
	7: Set timer start countdown to 7S,
	8: Set timer start countdown to 8S,
	9: Set timer start countdown to 9S.
 
The start countdown timer doesn't use military-grade time tracking,
because it's too resource hungry to have multiple running. Therefore
it is not recommended to use this feature where 100% time tracking
accuracy is important. This may or may not change in the future.


POSITION - SNAP THE TIMER - 
	W: Set timer position to top,
	S: Set timer position to bottom,
	A+W: Set timer position to top-left,
	W+D: Set timer position to top-right,
	A+S: Set timer position to bottom-left,
	S+D: Set timer position to bottom-right.
 
These hotkeys can quickly change the timer's position, without using
a mouse. The keys might be slow to respond, to allow for diagonals.

## Downloading source and editing for absolute beginners
1. Download and install Visual Studio 2022. Visual Studio 2019 is also usable.
2. Head to the top of this page, and click the "Code" button.
3. Click "Download ZIP".
4. Extract that ZIP file a place you remember.
5. Go inside the folder you just extracted, and look for "count_up.sln".
6. Double-click it, or right click, select "Open With...", then choose "Visual Studio 2022" or another Visual Studio.
7. Wait for the project to load.
8. Make your desired changes, if any.
9. Click "Start Without Debugging", the green hollow play button, or press Ctrl+F5.
10. Alternatively, if you want debugging enabled, you can simply click "Start".
11. It should build without errors.
12. The count-up stopwatch should appear after the build.

## License (MIT)
### English
Copyright (c) 2023 HeavyUtils

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

### Portuguese
Direitos Autorais (c) 2023 HeavyUtils

A permissão é concedida, gratuitamente, a qualquer pessoa que obtenha uma cópia deste software e arquivos de documentação associados (o "Software"), para utilizar o Software sem restrição, incluindo, mas não se limitando, os direitos de usar, copiar, modificar, mesclar, publicar, distribuir, sublicenciar e/ou vender cópias do Software, e de permitir que as pessoas a quem o Software é fornecido façam o mesmo, respeitando as seguintes condições:

O aviso de direitos autorais acima e este aviso de permissão devem ser incluídos em todas as cópias ou partes substanciais do Software.

O SOFTWARE É FORNECIDO "COMO ESTÁ", SEM GARANTIA DE QUALQUER TIPO, EXPRESSA OU IMPLÍCITA, INCLUINDO, MAS NÃO SE LIMITANDO ÀS GARANTIAS DE COMERCIALIZAÇÃO, ADEQUAÇÃO A UM FIM ESPECÍFICO E NÃO VIOLAÇÃO. EM NENHUM CASO OS AUTORES OU DETENTORES DOS DIREITOS AUTORAIS SERÃO RESPONSÁVEIS POR QUALQUER REIVINDICAÇÃO, DANOS OU OUTRAS RESPONSABILIDADES, SEJA EM AÇÃO DE CONTRATO, DELITO OU DE OUTRA FORMA, DECORRENTES DE, OU EM CONEXÃO COM O SOFTWARE OU O USO OU OUTRAS NEGOCIAÇÕES NO SOFTWARE.

### Danish
Ophavsret (c) 2023 HeavyUtils

Der gives tilladelse til enhver person, der får en kopi af dette software og de tilknyttede dokumentationsfiler (samlet "Softwaren"), til at anvende Softwaren uden begrænsning, herunder uden begrænsning rettighederne til at bruge, kopiere, ændre, sammenføje, offentliggøre, distribuere, underlicensere og/eller sælge kopier af Softwaren, og til at give personer, som Softwaren leveres til, tilladelse til at gøre det samme, underlagt følgende betingelser:

Ovenstående ophavsretsmeddelelse og denne tilladelse meddelelse skal være indeholdt i alle kopier eller betydelige dele af Softwaren.

SOFTWAREN LEVERES "SOM DEN ER", UDEN GARANTIER AF NOGEN ART, UDTRYKTE ELLER UNDERFORSTÅET, HERUNDER MEN IKKE BEGRÆNSET TIL GARANTIER OM SALGBARHED, EGNETHED TIL ET BESTEMT FORMÅL OG OVERTRÆDELSE. UNDER INGEN OMSTÆNDIGHEDER SKAL OPHAVSRETSHAVERNE ELLER TILLADELSESGIVERE VÆRE ANSVARLIGE FOR EVENTUELLE KRAV, SKADER ELLER ANDRE ANSVAR, UANSET OM DET ER EN KONTRAKTSAKTION, EN SKADES- ELLER ANDET, DER OPSTÅR UD AF, ELLER PÅ ANDEN MÅDE ER I FORBINDELSE MED SOFTWAREN ELLER BRUG ELLER ANDRE TILBAGEGANG AF SOFTWAREN.
