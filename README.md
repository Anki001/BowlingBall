## American Ten-Pin Bowling
> Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces the total score for the game.

> To calculate the score, you add up the total number of pins knocked down in each frame, including any bonus points earned from strikes or spares.

For example, if a bowler rolls a strike in the first frame, then knocks down 7 and 2 pins in the second frame, the score for the first frame would be 10 (for the strike) plus the next two rolls (7 and 2), for a total of 19. The score for the second frame would simply be 9 (7 + 2). You would continue this process for all 10 frames, adding the scores together to get the final total score.

---

# Rules
<p align="center">
	<ol>
		<li>Each game consists of 10 frames, and each frame allows up to 2 rolls to knock down all 10 pins.</li>
		<li>If all 10 pins are knocked down with the first roll (a strike), the frame is over and the score is calculated based on the next 2 rolls.</li>
		<li>If all 10 pins are knocked down with 2 rolls (a spare), the frame is over and the score is calculated based on the next roll.</li>
		<li>If fewer than 10 pins are knocked down in a frame, the score for that frame is simply the total number of pins knocked down.</li>
		<li>The score for each frame is added to the running total, which starts at 0.</li>
		<li>If a strike or spare is rolled in the final frame, the bowler gets one or two additional rolls, respectively, to add to the score.</li>
		<li>In the final frame, if the bowler rolls a strike in the first roll, they get two additional rolls to add to the score; if they roll a spare, they get one additional roll.</li>
		<li>The maximum possible score in a game is 300, achieved by rolling 12 strikes in a row (10 strikes in the first 10 frames, plus 2 additional strikes in the final frame).</li>
	</ol>
</p>
