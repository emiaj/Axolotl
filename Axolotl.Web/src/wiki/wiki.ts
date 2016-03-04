import {inject} from 'aurelia-framework';
import {IEntry} from './entry';
import {IContent} from './content';
import {WikiService} from './wiki-service'
@inject(WikiService)
export class Wiki {

    entry: IEntry;
    content: IContent;
    private index: number;

    constructor(private service: WikiService) {
    }

    activate(params: any): Promise<any> {
        return this.service.getLatest().then(result => {
            this.entry = result;
            this.index = 0;
            if (params.section) {
                const index = this.entry.content.findIndex(value => value.subHeading.startsWith(params.section));
                this.index = Math.max(index, 0);
            }
            this.content = this.entry.content[this.index];
        });
    }

    get next(): IContent {
        return this.entry.content[this.index + 1];
    }

    get previous(): IContent {
        return this.entry.content[this.index - 1];
    }

    get canMoveNext(): boolean {
        return this.next !== undefined;
    }
    get canMovePrevious(): boolean {
        return this.previous !== undefined;
    }

}