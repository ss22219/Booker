module net {
    export class connector {
        url: string;
        onerror: (ev: ErrorEvent) => any;
        onopen: (ev: Event) => any;
        onmessage: (ev: any) => any;
        scoket: WebSocket;
        
        constructor(url: string) {
            this.url = url;
        }

        connection() {
            this.scoket = new WebSocket(this.url);
            this.scoket.onopen = this.onopen;
            this.scoket.onerror = this.onerror;
            this.scoket.onmessage = this.onmessage;
        }
    }
}