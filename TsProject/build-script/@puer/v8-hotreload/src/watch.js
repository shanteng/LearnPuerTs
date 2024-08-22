import { Debugger } from './lib/debugger';
export default class Watcher {
    constructor() {
        this.debuggers = {};
    }
    addDebugger(debuggerPort) {
        this.debuggers[debuggerPort] = new Debugger({
            checkOnStartup: true,
            trace: true
        });
        this.debuggers[debuggerPort].open("127.0.0.1", debuggerPort);
    }
    removeDebugger(debuggerPort) {
        if (this.debuggers[debuggerPort]) {
            this.debuggers[debuggerPort].close();
            delete this.debuggers[debuggerPort];
        }
    }
    emitFileChanged(filepath) {
        Object.keys(this.debuggers).forEach((key) => {
            try {
                this.debuggers[+key].update(filepath);
            }
            catch (e) {
                console.error(e.stack);
            }
        });
    }
}
