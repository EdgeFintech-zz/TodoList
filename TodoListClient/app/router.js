import EmberRouter from '@ember/routing/router';
import config from 'todo-list-client/config/environment';

const Router = EmberRouter.extend({
  location: config.locationType,
  rootURL: config.rootURL
});

Router.map(function() {
  this.route('todo-items');
  this.route('test-route');
});

export default Router;
