import {Router, RouterConfiguration} from 'aurelia-router'

export class App {
  router: Router;
  
  configureRouter(config: RouterConfiguration, router: Router) {
    config.title = 'Axolotl';
    config.map([
      { route: ['', 'welcome'], name: 'welcome',      moduleId: 'welcome',      nav: true, title: 'Welcome' },
      { route: 'wiki', name: 'wiki', moduleId: 'wiki/wiki', nav:false, title:'Wiki'},
      { route: 'wiki/:section', name: 'wiki-section', moduleId: 'wiki/wiki', nav: false, title: 'Wiki' },
    ]);

    this.router = router;
  }
}
