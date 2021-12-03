MODULE Module1
        CONST robtarget Target_10:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        
        CONST robtarget home:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget storeX:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget store0:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget fieldCenter:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];

        CONST num zazor := 30;
        
        PERS bool isXstart:=TRUE;
        
        
        ! Player
        ! 1 - X
        ! 2 - 0
        ! 0 - game over
        PERS string strPlayer := "X";
        VAR robtarget curStore;
        VAR num Player:=1; 
        VAR num field{3,3}:=[
        [0,0,0],
        [0,0,0],
        [0,0,0]
        ];
        
        VAR num i;
        VAR num j;
        
        
        PERS num curCoord := 13;
        PERS string strField{3,3}:=[
        [" "," "," "],
        [" "," "," "],
        [" "," "," "]
        ];
        
        ! delta x To
        PERS num dxT :=-1;
        PERS num dyT :=1;
        PERS num dzT :=0;
        
        CONST num ActWait:=0;
        CONST num ActStep:=1;
        CONST num ActEndGame:=3;
        CONST num ActWinGame:=4;
        
        PERS num Action:=0;
                
        CONST num butWait:=0;
        CONST num butStart:=1;
        CONST num butEnd:=2;
        CONST num butClear:=3;
        CONST num butDraw:=4;
        
        PERS num buttonPressed:=0;
        
        PERS string status;
        
    PROC init()
        Action :=0;
        FOR i FROM 1 TO 3 DO
            FOR j FROM 1 TO 3 DO
                strField{i,j} := " ";
            ENDFOR
        ENDFOR
        
        IF isXstart THEN
            strPlayer:="X";
        ELSE
            strPlayer:="0";
        ENDIF
        
    ENDPROC
    
    PROC end()
        !moveJ home, v100, z100, gripper;
    ENDPROC

        
    PROC main()    
        init;
        WHILE TRUE DO
            buttonCapture;        
        ENDWHILE
    ENDPROC
    
    PROC buttonCapture()
        IF buttonPressed = butStart THEN
            status := "Game start";
            game;
        ELSEIF buttonPressed = butEnd THEN
            status:="Game interrupt";
        ELSEIF buttonPressed = butClear THEN
            status:="Clearing field, please wait";
        ELSEIF buttonPressed = butDraw THEN
            status:="Drawing field, please wait";
        ENDIF
            
    ENDPROC
    
    PROC game()
        init;
        WHILE not Action=ActEndGame DO
            chooseAction Action;            
        ENDWHILE
        end;
    ENDPROC
    
    PROC chooseAction(num Action)
        IF Action = ActStep THEN 
            moveX0;
        ENDIF
    ENDPROC
        
    PROC moveX0()
        
        i := dyT+2;
        j := dxT+2;
        
        curCoord := 10*j + i;
        IF strField{i,j}=" " THEN
            strField{i, j} := strPlayer;
            switchPlayer;            
            moveCube curStore, Offs(fieldCenter, 2*zazor*dyT, 2*zazor*dxT, 2*zazor*dzT);
            status := "Wait for the "+ strPlayer+" step";
       ENDIF
    ENDPROC
    
    PROC switchPlayer()
        IF strPlayer="X" THEN
            curStore := storeX;
            strPlayer:="0";
        ELSE 
            curStore := store0;
            strPlayer:="X";
        ENDIF
    ENDPROC
    
    PROC moveCube(robtarget pfrom, robtarget pto)
        grab(pfrom);
        stand(pto);
    ENDPROC    
    
    PROC grab(robtarget point)
        MoveJ point,v1000,z1,gripper\WObj:=Workobject_1;
        MoveL Offs(point, 0,0,zazor),v100,fine,gripper\WObj:=Workobject_1;
        PulseDO\High,do_GripClose;

        !WaitDI di_GripClosed,1;
        MoveJ point,v100,z1,gripper\WObj:=Workobject_1;
    ENDPROC
    
    PROC stand(robtarget point)
        MoveJ point,v1000,z1,gripper\WObj:=Workobject_1;
        MoveL Offs(point, 0,0,zazor),v100,fine,gripper\WObj:=Workobject_1;
        PulseDO\High,do_GripOpen;
        !WaitDI di_GripOpened,1;
        MoveJ point,v100,z1,gripper\WObj:=Workobject_1;
    ENDPROC
    PROC Path_10()
        MoveL Target_10,v1000,z100,gripper\WObj:=Workobject_1;
    ENDPROC

    
    
ENDMODULE