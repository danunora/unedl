package com.dnunora;

import static com.dnunora.ThreadColor.ANSI_BLUE;

public class AnotherThread extends Thread{

    private static final int TIMEOUTX = 5000;

    @Override
    public void run() {
        System.out.println(ANSI_BLUE + currentThread().getName());
        // put the thread to sleep
        try{
            Thread.sleep(TIMEOUTX);
        }catch (InterruptedException e){
            System.out.println(ANSI_BLUE + "ANOTHER THREAD WOKE ME UP");
            return;    // terminate the anotherThread instance
        }
        System.out.println(ANSI_BLUE + "ANOTHER THREAD " +TIMEOUTX+ " milliseconds passed");
    }
}
