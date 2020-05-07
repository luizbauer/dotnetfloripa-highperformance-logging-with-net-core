import { check } from 'k6';
import http from 'k6/http';

export default function() {
  let r = http.get('http://127.0.0.1/loggerprovider');
  let body = JSON.parse(r.body);

  check(r, {
    'status is 200': r => r.status === 200,
    'status provider': r => body.provider == __ENV.provider,
    'status logLevel': r => body.logLevel == __ENV.logLevel,
    'status outputMode': r => body.outputMode == __ENV.outputMode
  });
}