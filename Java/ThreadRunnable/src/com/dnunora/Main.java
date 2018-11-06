package com.dnunora;

import static com.dnunora.ThreadColor.ANSI_GREEN;
import static com.dnunora.ThreadColor.ANSI_PURPLE;
import static com.dnunora.ThreadColor.ANSI_RED;

public class Main {

    public static void main(String[] args) {
        System.out.println(ANSI_PURPLE + "MAIN THREAD");

        Thread anotherThread = new AnotherThread();
        anotherThread.setName("ANOTHER THREAD");
        // start will execute the run, if We use run(), it will
        // be the main thread
        anotherThread.start();

        // Anonymous class
        new Thread(){
            public void run() {
                System.out.println(ANSI_GREEN + "ANONYMOUS THREAD");
            }
        }.start();

        // Thread with Runnable, more convenient
        Thread myRunnableThread = new Thread(new MyRunnable());
        myRunnableThread.start();

        // Anonymous Runnable, more convenient
        Thread anRunnableThread = new Thread(new Runnable() {
            @Override
            public void run() {
                System.out.println(ANSI_RED + "ANONYMOUS RUNNABLE THREAD");
                try {
                    anotherThread.join(); // joining a thread, time out
                    System.out.println(ANSI_RED + "ANOTHER THREAD terminated or timed out");
                } catch (InterruptedException e){
                    System.out.println(ANSI_RED + "COULDN'T WAIT, INTERRUPTED");
                }
            }
        });
        anRunnableThread.start();

        // Interrupt a thread, anotherThread
        //anotherThread.interrupt();

        System.out.println(ANSI_PURPLE + "MAIN THREAD AGAIN");
    }
}
