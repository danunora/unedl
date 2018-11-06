package com.dnunora;

import static com.dnunora.ThreadColor.ANSI_BLUE;

public class AnotherThread extends Thread{

    @Override
    public void run() {
        System.out.println(ANSI_BLUE + currentThread().getName());
        // put the thread to sleep
        try{
            Thread.sleep(3000);
        }catch (InterruptedException e){
            System.out.println(ANSI_BLUE + "ANOTHER THREAD WOKE ME UP");
        }
        System.out.println(ANSI_BLUE + "ANOTHER THREAD 3 seconds passed");
    }
}
