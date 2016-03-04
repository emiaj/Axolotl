import {inject} from 'aurelia-framework';
import {HttpClient} from 'aurelia-fetch-client';
import {Configure} from 'aurelia-configuration';
import {IEntry} from './entry';
@inject(HttpClient, Configure)
export class WikiService {
    constructor(private http: HttpClient,private config: Configure) {
    }

    getLatest(): Promise<IEntry> {
        return this.http.fetch(this.config.get("api.server") + "/api/data")
            .then(response => response.json())
            .then(json => <IEntry>json);
    }
}