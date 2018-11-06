package com.dnunora;

import static com.dnunora.ThreadColor.ANSI_GREEN;
import static com.dnunora.ThreadColor.ANSI_PURPLE;

public class Main {

    public static void main(String[] args) {
        System.out.println(ANSI_PURPLE + "MAIN THREAD");

        Thread anotherThread = new AnotherThread();
        anotherThread.setName("ANOTHER THREAD");
        anotherThread.start();

        // Anonymous class
        new Thread(){
            public void run() {
                System.out.println(ANSI_GREEN + "ANONYMOUS THREAD");
            }
        }.start();

        // Thread with Runnable
        Thread myRunnableThread = new Thread(new MyRunnable());
        myRunnableThread.start();

        System.out.println(ANSI_PURPLE + "MAIN THREAD AGAIN");
    }
}
