   M S B A M L   `   `   `  ����N  JAssignment5MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Assignment5MathGameAssignment5MathGame  5   	   $    Assignment5MathGame.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Assignment5MathGame     5   	     � Title$  
GameWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       j� Stretch$ Uniform=�6    �� ImageSource$# images/babyCaptainAmerica.png��6+   .+�5   
   �� -   5         ��Name$ btnStart��5      $��
Start Game��6#   $
��Left=�68   $��	46,57,0,0q�6S   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5         ��Name$ lblRandomNum1��5      $�� ��6'   $
��Left=�62   $��238,147,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ lblOperation��5      $�� ��6&   $
��Left=�61   $��280,147,0,0q�6L   $	��Top=�6a    J� RenderTransformOrigin$ -0.241,0.473&�6y   �� 5   
   -   5        $ lblRandomNum2��5      $�� ��6'   $
��Left=�62   $��329,147,0,0q�6M   $	��Top=�6b   �� 5   
   -   5         ��Name$ txtUserAnswer��5      $
��Left=�6)   $��23��6D   $��388,144,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $	��Top=�6z   $	��120��6�   $ 0.201,-0.79&�6�   {�.  6�   �� 5   
   -   5        $ 	btnSubmit��5      $��Submit��6$   $
��Left=�65   $��674,150,0,0q�6P   $	��Top=�6e   $��75��6}   {�.  6�   �� 5   
   -   5        $ lblPlayerName��5      $�� ��6'   $
��Left=�62   $��
329,31,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ lblRightWrongAnswer��5      $�� ��6-   $
��Left=�68   $��238,244,0,0q�6S   $	��Top=�6h   �� 5   
   -	   5        $ lblQuestionNumber��5      $�� ��6+   $
��Left=�66   $��
46,144,0,0q�6Q   $	��Top=�6e   $ 0.496,1.256&�6}   �� 5   
   -
   5        $ lblFinalScore��5      $��Final Score: ��6'   $
��Left=�6?   $��
66,330,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5        $ lblTotalWrong��5      $�� ��6'   $
��Left=�62   $��210,356,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ lblTotalRight��5      $�� ��6'   $
��Left=�62   $��210,330,0,0q�6M   $	��Top=�6b   $ -2.534,0.156&�6z   �� 5   
   -   5        $ lblRight��5      $��Right��6"   $
��Left=�62   $��158,330,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ lblWrong��5      $��Wrong��6"   $
��Left=�62   $��158,356,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��
173,57,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ lblTimer��5      $�� ��6"   $
��Left=�6-   $��
359,51,0,0q�6H   $	��Top=�6\   �� 5   
   -   5        $ lblTime��5      $�� ��6!   $
��Left=�6,   $��
314,51,0,0q�6G   $	��Top=�6[   $ 
0.044,1.85&�6s   5      5       