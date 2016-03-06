import 'bootstrap';
import {Aurelia} from 'aurelia-framework';

export function configure(aurelia: Aurelia) {
  aurelia.use
    .standardConfiguration()
      .developmentLogging()
      .plugin('aurelia-configuration',config => {
          config.setEnvironments({
              development: ['localhost'],
              production: ['axolotl-wiki-web.azurewebsites.net']
          });
          config.setDirectory('config-files');
          config.setConfig('axolotl-config.json');
      });

  //Uncomment the line below to enable animation.
  //aurelia.use.plugin('aurelia-animator-css');

  //Anyone wanting to use HTMLImports to load views, will need to install the following plugin.
  //aurelia.use.plugin('aurelia-html-import-template-loader')

  aurelia.start().then(() => aurelia.setRoot());
}
