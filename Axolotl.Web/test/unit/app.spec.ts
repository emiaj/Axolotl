import './setup';
import {App} from '../../src/app';

class RouterStub {
  routes;
  
  configure(handler) {
    handler(this);
  }
  
  map(routes) {
    this.routes = routes;
  }
}

describe('the App module', () => {
  var sut, mockedRouter;

  beforeEach(() => {
    mockedRouter = new RouterStub();
    sut = new App();
    sut.configureRouter(mockedRouter, mockedRouter);
  });

  it('contains a router property', () => {
    expect(sut.router).toBeDefined();
  });

  it('configures the router title', () => {
      expect(sut.router.title).toEqual('Axolotl');
  });

  it('should have a welcome route', () => {
    expect(sut.router.routes).toContain({ route: ['','welcome'], name: 'welcome',  moduleId: 'welcome', nav: true, title:'Welcome' });
  });

  it('should have a wiki route', () => {
      expect(sut.router.routes).toContain({ route: 'wiki', name: 'wiki', moduleId: 'wiki/wiki', nav: false, title: 'Wiki' });
  });

  it('should have a wiki section route', () => {
      expect(sut.router.routes).toContain({ route: 'wiki/:section', name: 'wiki-section', moduleId: 'wiki/wiki', nav: false, title: 'Wiki' });
  });
});
